using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySiteMarchand;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ProjetSiteMarchand
{
    class Program
    {

        static void Main(string[] args)
        {

            //Création des variable locales
            ConsoleKeyInfo Choix;
            ConsoleKeyInfo ConfirmeSupp;
            bool ChoixValide = false;

            // Création de la collection Catalogue, Panier et Compte Client
            List<Client> CompteClients = new List<Client>();
            List<Article> MonCatalogue = new List<Article>();
            List<Article> Panier = new List<Article>();

#region Creation des articles initiaux du catalogue
            MonCatalogue.Add(new Article() { Name = "Ecran Ordinateur", Categorie = "Informatique", Prix = 124.55, Quantite = 100 });
            MonCatalogue.Add(new Article() { Name = "ordinateur", Categorie = "Informatique", Prix = 1240.75, Quantite = 200 });
            MonCatalogue.Add(new Article() { Name = "Clavier", Categorie = "Informatique", Prix = 89.20, Quantite = 10 });
            MonCatalogue.Add(new Article() { Name = "Souris", Categorie = "Informatique", Prix = 24.55, Quantite = 10 });
#endregion

#region Creation de mes clients
            CompteClients.Add(new Client("GAUDRON","Fabien",new DateTime(1983, 08, 03),"14 Route de Briare 45250 Ousson","fabien.gaudron@gmail.com",new Compte()));
            CompteClients.Add(new Client("BERTHELOT", "Pierre", new DateTime(1984, 04, 20), "50 Grande rue 26500 Bourg les Valence", "pierre.berthelot@gmail.com",new Compte()));
            CompteClients.Add(new Client("LABAUME", "Gregory", new DateTime(1985, 08, 12), "Lieu dit Terregaie 58000 Pinsac", "greg.labaume@gmail.com", new Compte()));
#endregion
            do
            {
                #region Menu Principal
                do
                {
                    Console.WriteLine("\n\t\t*************** Menu Principal ***************\n" +
                            "\n\t\t1 - Menu CLIENT\n" +
                            "\t\t2 - Menu Admin Site\n");

                    // On récupère le choix de l'utilisateur
                    Choix = Console.ReadKey(true);

                    try
                    {
                        if (Choix.KeyChar.Equals('1') || Choix.KeyChar.Equals('2'))
                        {
                            ChoixValide = true;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erreur de saisie, la valeur doit être 1 ou 2");
                    }

                }
                while (!ChoixValide);

                Console.Clear();
                #endregion


                if (Choix.KeyChar.Equals('1'))
                {
                    int IndexPersonneActive = 0;
                    do
                    {
                        Console.WriteLine("Êtes vous un nouveau client ? ( y / n )");
                        Choix = Console.ReadKey(true);
                        if (Choix.KeyChar.Equals('y'))
                        {
                            #region Ajout d'un nouveau client
                            Console.WriteLine("Nom :");
                            string TmpNom = Console.ReadLine();

                            Console.WriteLine("Prenom :");
                            string TmpPrenom = Console.ReadLine();

                            Console.WriteLine("Date d'anniversaire :");
                            Console.WriteLine("Annee :");
                            int TmpAnnee = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mois :");
                            int TmpMois = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Jour :");
                            int TmpJour = Convert.ToInt32(Console.ReadLine());

                            // Récuparation de l'adresse du client avec test de validation de l'adresse postale
                            string TmpAdresse = "0";
                            bool AdresseValide = false;
                            do
                            {
                                Console.WriteLine("Adresse Postale :");
                                try
                                {
                                    TmpAdresse = Console.ReadLine();
                                    AdresseValide = Client.IsValideAdressePostale(TmpAdresse);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Erreur de saisie, la valeur doit être une adresse postale valide");
                                }

                            } while (!AdresseValide);


                            // Récupération de l'adresse mail du nouveau client avec test de validation de l'adresse email
                            string TmpMail = "0";
                            bool EmailValide = false;
                            do
                            {
                                Console.WriteLine("Adresse Mail :");
                                try
                                {
                                    TmpMail = Console.ReadLine();
                                    EmailValide = Client.IsValideMail(TmpMail);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Erreur de saisie, la valeur doit être une adresse mail valide");
                                }
                            }
                            while (!EmailValide);


                            CompteClients.Add(new Client(TmpNom, TmpPrenom, new DateTime(TmpAnnee, TmpMois, TmpJour), TmpAdresse, TmpMail, new Compte()));
                            IndexPersonneActive = CompteClients.Count - 1;
                            #endregion

                        }
                        else
                        {
                            #region Recherche du client actif
                            Console.WriteLine("Quel est votre NOM :");
                            string TmpNom1 = Console.ReadLine().ToString();
                            Client ClientTrouve = CompteClients.FirstOrDefault(i => i.Nom == TmpNom1);
                            if (ClientTrouve == null)
                            {
                                Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé votre Compte ?");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(ClientTrouve.AfficherClient());
                                IndexPersonneActive = CompteClients.IndexOf(ClientTrouve);
                            }
                            #endregion
                        }
                        Console.Clear();

                    } while (IndexPersonneActive == 0);

                    do
                    {
                        Console.WriteLine("\nMenu Client: \n" +
                          "\t\t*************** Sous Menu Article ***************\n" +
                          "\t\t1 - Rechercher un Article par ref\n" +
                          "\t\t2 - Rechercher un Article par nom\n" +
                          "\t\t3 - Afficher tous les articles\n" +
                          "\n" +
                          "\t\t*************** Sous Menu Panier ****************\n" +
                          "\t\ta - Ajout d'un article dans votre panier\n" +
                          "\t\tm - Modifier votre panier\n" +
                          "\t\tv - Afficher votre Panier\n" +
                          "\t\tp - Valider votre Panier\n" +
                          "\n" +
                          "\t\t*************** Sous Menu Application ************\n" +
                          "\t\t9 - Quittez le programme\n\n" +
                          "Bonjour " + CompteClients[IndexPersonneActive].Prenom + " !\n\n" +
                          "Votre choix :");

                        // On récupère le choix de l'utilisateur
                        Choix = Console.ReadKey(true);
                        Console.Clear();

                        // On défini les différents comportement en fonction du choix récupéré
                        switch (Choix.KeyChar)
                        {
                            #region Recherche d'un article par Référence
                            case '1':
                                Console.WriteLine("Recherche d'un article par Référence\n\n");
                                Console.WriteLine("Quelle référence recherchez vous :");
                                string TmpRef = Console.ReadLine().ToString();
                                Article ArticleTrouve = MonCatalogue.FirstOrDefault(i => i.IdArticle == TmpRef);
                                if (ArticleTrouve == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici l'article avec la référence : " + ArticleTrouve.IdArticle);
                                    Console.WriteLine(ArticleTrouve.AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Recherche d'un article par Nom
                            case '2':
                                Console.WriteLine("Recherche d'un article par Nom\n\n");
                                Console.WriteLine("Quel est l'article que vous cherchez :");
                                String TmpName3 = Console.ReadLine();
                                Article ArticleTrouve4 = MonCatalogue.FirstOrDefault(i => i.Name == TmpName3);
                                if (ArticleTrouve4 == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici l'article avec le Nom " + ArticleTrouve4.Name + " :");
                                    Console.WriteLine(ArticleTrouve4.AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Affichage de tous les articles du catalogue
                            case '3':
                                Console.WriteLine("Affichage de tous les articles du catalogue\n\n");
                                for (int i = 0; i < MonCatalogue.Count; i++)
                                {
                                    Console.WriteLine(MonCatalogue[i].AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Ajout d'un article dans le panier
                            case 'a':
                                Console.WriteLine("Ajout d'un article dans votre panier\n\n");
                                Article ArticleTrouve3 = new Article();
                                do
                                {
                                    Console.WriteLine("Nom de l'article :");
                                    string TmpNom = Console.ReadLine();
                                    ArticleTrouve3 = MonCatalogue.FirstOrDefault(i => i.Name == TmpNom);

                                    if (ArticleTrouve3 == null)
                                    {
                                        Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                                    }
                                    else
                                    {
                                        Console.WriteLine(ArticleTrouve3.AfficherArticle());
                                    }

                                } while (ArticleTrouve3 == null);


                                Console.WriteLine("Ajouter cet article dans votre panier ? ( y / n )\n");
                                Choix = Console.ReadKey(true);

                                if (Choix.KeyChar.Equals('y'))
                                {
                                    Panier.Add(ArticleTrouve3);
                                    Console.WriteLine("\nArticle ajouté à votre panier !!!");
                                }
                                else
                                {
                                    Console.WriteLine("L'article n'a pas été ajouté à votre panier !!!");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Modification du panier
                            case 'm':
                                Console.WriteLine("Modifier le panier par nom\n\n");
                                Console.WriteLine("Quel est le nom de l'article que vous voulez supprimer :");
                                string TmpNomModif = Console.ReadLine();
                                Article ArticleTrouve1 = Panier.FirstOrDefault(i => i.Name == TmpNomModif);
                                int Indice = Panier.FindIndex(i => i.Name == TmpNomModif);
                                if (ArticleTrouve1 == null)
                                {
                                    Console.WriteLine("Ce Nom n'existe pas dans votre panier, nous ne pouvons pas modifier votre panier");
                                }
                                else
                                {
                                    Console.WriteLine("Voici l'article " + ArticleTrouve1.Name + " :");
                                    Console.WriteLine(Panier[Indice].AfficherArticle());

                                    Console.WriteLine("Voulez vous le supprimer de votre panier  ? ( y / n ) ");
                                    Choix = Console.ReadKey(true);

                                    if (Choix.KeyChar.Equals('y'))
                                    {
                                        Panier.Remove(ArticleTrouve1);
                                        Console.WriteLine("Article supprimé de votre panier !!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("L'article n'a pas été retiré de votre panier !!!");
                                    }
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Affichage du panier
                            case 'v':
                                if (Panier.Count != 0)
                                {
                                    for (int i = 0; i < Panier.Count; i++)
                                    {
                                        Console.WriteLine(Panier[i].AfficherArticle());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Votre Panier est vide, depechez vous d'acheter !!!!");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Validation du panier
                            case 'p':
                                if (Panier.Count == 0)
                                {
                                    Console.WriteLine("Votre Panier est vide, depechez vous d'acheter !!!!");
                                }
                                else
                                {
                                    for (int i = 0; i < Panier.Count; i++)
                                    {
                                        Console.WriteLine(Panier[i].AfficherArticle());
                                    }

                                    Console.WriteLine("Voulez vous VALIDER et PAYER votre panier  ? ( y / n ) ");
                                    Choix = Console.ReadKey(true);

                                    if (Choix.KeyChar.Equals('y'))
                                    {

                                        Console.WriteLine("Vérification des données bancaires en cours...");
                                        for (int i = 0; i <= 100; i++)
                                        {
                                            System.Threading.Thread.Sleep(50);

                                            if (i == 10 || i == 24 || i == 42 || i == 59 || i == 67 || i == 86 || i == 100)
                                            {
                                                Console.Write("  " + i + " %  ");
                                            }
                                            else
                                            {
                                                Console.Write("*");
                                            }
                                        }

                                        // Test anniversaire
                                        CompteClients[IndexPersonneActive].Compte.CadeauAnniversaire(CompteClients[IndexPersonneActive]);

                                        // Calcul des depenses effectuées et affectation à la variable depense
                                        for (int i = 0; i < Panier.Count; i++)
                                        {
                                            CompteClients[IndexPersonneActive].Compte.Depense += Panier[i].Prix;
                                        }

                                        Console.WriteLine("\n\nPayement VALIDE...MERCI");

                                    }
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Permet de quitter le prohramme + test de frappe
                            case '9':
                                Console.WriteLine("\n\nMerci d'avoir utilisé notre programme, A+\n");
                                break;

                            default:
                                try
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                catch (ArgumentOutOfRangeException)
                                {

                                    Console.WriteLine("Erreur de saisie, merci de recommencer");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            #endregion


                        }
                    } while (Choix.KeyChar != '9');

                }
                else
                {
                    do
                    {

                        #region Affichage du menu pour l'utilisateur, on récupère la valeur de la touche appuyée
                        Console.WriteLine("\nMenu Back Office: \n" +
                                          "\t\t*************** Sous Menu Article ***************\n" +
                                          "\t\t1 - Rechercher un Article par ref\n" +
                                          "\t\t2 - Ajouter un Article\n" +
                                          "\t\t3 - Supprimer un Artcile\n" +
                                          "\t\t4 - Modifier un Article\n" +
                                          "\t\t5 - Rechercher un Article par nom\n" +
                                          "\t\t6 - Rechercher un Article par intervalle de prix\n" +
                                          "\t\t7 - Afficher tous les articles\n" +
                                          "\n" +
                                          "\t\t*************** Sous Menu Client ****************\n" +
                                          "\t\tf - Recherche d'un client par nom\n" +
                                          "\t\ta - Ajout d'un client\n" +
                                          "\t\ts - Supprimmr un clients\n" +
                                          "\t\tm - Modifier un clients\n" +
                                          "\t\tb - Afficher toutes les fiches clients\n" +
                                          "\n" +
                                          "\t\t*************** Sous Menu Application ************\n" +
                                          "\t\t9 - Quittez le programme\n\n" +
                                          "Votre choix :");

                        // On récupère le choix de l'utilisateur
                        Choix = Console.ReadKey(true);
                        Console.Clear();
                        #endregion

                        // On défini les différents comportement en fonction du choix récupéré
                        switch (Choix.KeyChar)
                        {
                            #region Recherche d'un article par Référence
                            case '1':
                                Console.WriteLine("Recherche d'un article par Référence\n\n");
                                Console.WriteLine("Quelle référence recherchez vous :");
                                string TmpRef = Console.ReadLine().ToString();
                                Article ArticleTrouve = MonCatalogue.FirstOrDefault(i => i.IdArticle == TmpRef);
                                if (ArticleTrouve == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici l'article avec la référence : " + ArticleTrouve.IdArticle);
                                    Console.WriteLine(ArticleTrouve.AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Ajout d'un Article dans le catalogue
                            case '2':
                                Console.WriteLine("Ajout d'un Article dans le catalogue\n\n");
                                Console.WriteLine("Catégorie de l'article :");
                                string TmpCategorie = Console.ReadLine();

                                Console.WriteLine("Name de l'Article :");
                                String TmpName = Console.ReadLine();

                                // Recuperation et test du prix de l'article
                                bool PrixValide = false;
                                double TmpPrix = 0.0;
                                do
                                {
                                    Console.WriteLine("Prix de l'Article :");
                                    try
                                    {
                                        TmpPrix = Convert.ToDouble(Console.ReadLine());
                                        PrixValide = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Erreur de saisie, la valeur doit être un nombre décimale");
                                    }
                                } while (!PrixValide);


                                // Recuperation et test de la quantite de l'article
                                bool QuantiteValide = false;
                                int TmpQte = 0;
                                do
                                {
                                    Console.WriteLine("Quantité de l'Article :");
                                    try
                                    {
                                        TmpQte = Convert.ToInt32(Console.ReadLine());
                                        if (TmpQte < 0)
                                        {
                                            throw new FormatException();
                                        }
                                        QuantiteValide = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Erreur de saisie, la valeur doit être un nombre entier positif");
                                    }

                                } while (!QuantiteValide);


                                // On teste la creation de l'article
                                try
                                {
                                    MonCatalogue.Add(new Article(TmpName, TmpCategorie, TmpPrix, TmpQte));
                                    Console.WriteLine("Article ajouté !!!");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Une erreur de déclaration d'Article a été obtenu, l'article n'a pas été ajouté");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Suppression d'un article par référence
                            case '3':
                                Console.WriteLine("Suppression d'un article par référence\n\n");
                                Console.WriteLine("Quel est la référence de l'article que vous voulez supprimer :");
                                string TmpRefSupp = Console.ReadLine();
                                Article ArticleTrouve2 = MonCatalogue.FirstOrDefault(i => i.IdArticle == TmpRefSupp);
                                if (ArticleTrouve2 == null)
                                {
                                    Console.WriteLine("Cette référence n'existe pas, nous ne pouvons pas supprimer l'article correspondant");
                                }
                                else
                                {
                                    MonCatalogue.Remove(ArticleTrouve2);
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Modifier l'article par référence
                            case '4':
                                Console.WriteLine("Modifier l'article par référence\n\n");
                                Console.WriteLine("Quel est la référence de l'article que vous voulez modifier :");
                                string TmpRefModif = Console.ReadLine();
                                Article ArticleTrouve3 = MonCatalogue.FirstOrDefault(i => i.IdArticle == TmpRefModif);
                                if (ArticleTrouve3 == null)
                                {
                                    Console.WriteLine("Cette référence n'existe pas, nous ne pouvons pas modifier l'article correspondant");
                                }
                                else
                                {
                                    MonCatalogue.Remove(ArticleTrouve3);
                                    Console.WriteLine("Modifier la catégorie de l'Article " + ArticleTrouve3.Categorie + " par :");
                                    string TmpCategorie2 = Console.ReadLine();

                                    Console.WriteLine("Modifier le nom de l'Article " + ArticleTrouve3.Name + " par :");
                                    string TmpName2 = Console.ReadLine();


                                    // Recuperation et test du prix de l'article
                                    bool PrixValide1 = false;
                                    double TmpPrix2 = 0.0;
                                    do
                                    {
                                        Console.WriteLine("Modifier le prix de l'Article " + ArticleTrouve3.Prix + " par :");
                                        try
                                        {
                                            TmpPrix2 = Convert.ToDouble(Console.ReadLine());
                                            PrixValide1 = true;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Erreur de saisie, la valeur doit être un nombre décimale");
                                        }
                                    } while (!PrixValide1);


                                    // Recuperation et test de la quantite de l'article
                                    bool QuantiteValide1 = false;
                                    int TmpQte2 = 0;
                                    do
                                    {
                                        Console.WriteLine("Modifier la Quantité de l'Article " + ArticleTrouve3.Quantite + " par :");
                                        try
                                        {
                                            TmpQte2 = Convert.ToInt32(Console.ReadLine());
                                            if (TmpQte2 < 0)
                                            {
                                                throw new FormatException();
                                            }
                                            QuantiteValide1 = true;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Erreur de saisie, la valeur doit être un nombre entier positif");
                                        }

                                    } while (!QuantiteValide1);


                                    MonCatalogue.Add(new Article(TmpName2, TmpCategorie2, TmpPrix2, TmpQte2));
                                    Console.WriteLine("Fiche Client modifié !!!");

                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Recherche d'un article par Nom
                            case '5':
                                Console.WriteLine("Recherche d'un article par Nom\n\n");
                                Console.WriteLine("Quel est l'article que vous cherchez :");
                                String TmpName3 = Console.ReadLine();
                                Article ArticleTrouve4 = MonCatalogue.FirstOrDefault(i => i.Name == TmpName3);
                                if (ArticleTrouve4 == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici l'article avec le Nom " + ArticleTrouve4.Name + " :");
                                    Console.WriteLine(ArticleTrouve4.AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Rechercher un article par intervalle de prix
                            case '6':
                                Console.WriteLine("Recherche d'un article par intervalle de prix de vente\n\n");
                                Console.WriteLine("Quel est le prix de départ de votre intervalle :");
                                Double TmpPrixStart = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Quel est le prix de fin de votre intervalle :");
                                Double TmpPrixEnd = Convert.ToDouble(Console.ReadLine());

                                foreach (Article ArticleTrouvePrix in MonCatalogue)
                                {
                                    if (ArticleTrouvePrix.Prix >= TmpPrixStart)
                                    {
                                        if (ArticleTrouvePrix.Prix <= TmpPrixEnd)
                                        {
                                            Console.WriteLine(ArticleTrouvePrix.AfficherArticle());
                                        }
                                    }
                                }


                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Affichage de tous les articles du catalogue
                            case '7':
                                Console.WriteLine("Affichage de tous les articles du catalogue\n\n");
                                for (int i = 0; i < MonCatalogue.Count; i++)
                                {
                                    Console.WriteLine(MonCatalogue[i].AfficherArticle());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Ajout d'un client dans la list CompteClient
                            case 'a':
                                Console.WriteLine("Ajout d'un client dans la base CompteClient\n\n");
                                Console.WriteLine("Nom du client :");
                                string TmpNom = Console.ReadLine();

                                Console.WriteLine("Prenom du client :");
                                string TmpPrenom = Console.ReadLine();

                                Console.WriteLine("Date d'anniversaire du client :");
                                Console.WriteLine("Annee :");
                                int TmpAnnee = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Mois :");
                                int TmpMois = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Jour :");
                                int TmpJour = Convert.ToInt32(Console.ReadLine());

                                // Récuparation de l'adresse du client avec test de validation de l'adresse postale
                                string TmpAdresse = "0";
                                bool AdresseValide = false;
                                do
                                {
                                    Console.WriteLine("Adresse du client :");
                                    try
                                    {
                                        TmpAdresse = Console.ReadLine();
                                        AdresseValide = Client.IsValideAdressePostale(TmpAdresse);
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Erreur de saisie, la valeur doit être une adresse postale valide");
                                    }

                                } while (!AdresseValide);



                                // Récupération de l'adresse mail du nouveau client avec test de validation de l'adresse email
                                string TmpMail = "0";
                                bool EmailValide = false;
                                do
                                {
                                    Console.WriteLine("Mail du client :");
                                    try
                                    {
                                        TmpMail = Console.ReadLine();
                                        EmailValide = Client.IsValideMail(TmpMail);
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Erreur de saisie, la valeur doit être une adresse mail valide");
                                    }
                                }
                                while (!EmailValide);


                                CompteClients.Add(new Client(TmpNom, TmpPrenom, new DateTime(TmpAnnee, TmpMois, TmpJour), TmpAdresse, TmpMail, new Compte()));
                                Console.WriteLine("Client ajouté !!!");


                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Recherche d'un client par nom
                            case 'f':
                                Console.WriteLine("Recherche d'un client par Nom\n\n");
                                Console.WriteLine("Quelle nom de client recherchez vous :");
                                string TmpNom1 = Console.ReadLine().ToString();
                                Client ClientTrouve = CompteClients.FirstOrDefault(i => i.Nom == TmpNom1);
                                if (ClientTrouve == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé le client que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici le client demnadé : ");
                                    Console.WriteLine(ClientTrouve.AfficherClient());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Modifier un client par nom
                            case 'm':
                                Console.WriteLine("Modifier le client par nom\n\n");
                                Console.WriteLine("Quel est le nom du client que vous voulez modifier :");
                                string TmpNomModif = Console.ReadLine();
                                Client ClientTrouve1 = CompteClients.FirstOrDefault(i => i.Nom == TmpNomModif);
                                int Indice = CompteClients.FindIndex(i => i.Nom == TmpNomModif);
                                if (ClientTrouve1 == null)
                                {
                                    Console.WriteLine("Ce Nom n'existe pas, nous ne pouvons pas modifier le client correspondant");
                                }
                                else
                                {
                                    Console.WriteLine("Modifier le nom du client " + ClientTrouve1.Nom + " par :");
                                    CompteClients[Indice].Nom = Console.ReadLine();

                                    Console.WriteLine("Modifier le prenom du client " + ClientTrouve1.Prenom + " par :");
                                    CompteClients[Indice].Prenom = Console.ReadLine();

                                    Console.WriteLine("Modifier la date de Naisance du client " + ClientTrouve1.DateNaissance + " par :");
                                    Console.WriteLine("Date d'anniversaire du client :");
                                    Console.WriteLine("Annee :");
                                    int TmpAnnee2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Mois :");
                                    int TmpMois2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Jour :");
                                    int TmpJour2 = Convert.ToInt32(Console.ReadLine());
                                    CompteClients[Indice].DateNaissance = new DateTime(TmpAnnee2, TmpMois2, TmpJour2);

                                    CompteClients[Indice].AdresseMail = Console.ReadLine();

                                    // Récuparation de l'adresse du client avec test de validation de l'adresse postale
                                    bool AdresseValide1 = false;
                                    do
                                    {
                                        Console.WriteLine("Modifier l'adresse du client " + ClientTrouve1.Adresse + " par :");
                                        try
                                        {
                                            TmpAdresse = Console.ReadLine();
                                            AdresseValide = Client.IsValideAdressePostale(TmpAdresse);
                                            CompteClients[Indice].Adresse = TmpAdresse;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Erreur de saisie, la valeur doit être une adresse postale valide");
                                        }

                                    } while (!AdresseValide1);



                                    // Récupération de l'adresse mail du nouveau client avec test de validation de l'adresse email
                                    bool EmailValide1 = false;
                                    do
                                    {
                                        Console.WriteLine("Modifier l'adresse mail du client " + ClientTrouve1.AdresseMail + " par :");
                                        try
                                        {
                                            TmpMail = Console.ReadLine();
                                            EmailValide = Client.IsValideMail(TmpMail);
                                            CompteClients[Indice].AdresseMail = TmpMail;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Erreur de saisie, la valeur doit être une adresse mail valide");
                                        }
                                    }
                                    while (!EmailValide1);
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Affichage de tous les clients
                            case 'b':
                                Console.WriteLine("Affichage de tous les clients du site\n\n");
                                for (int i = 0; i < CompteClients.Count; i++)
                                {
                                    Console.WriteLine(CompteClients[i].AfficherClient());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Suppression d'un client
                            case 's':
                                Console.WriteLine("Suppression d'un client par Nom\n\n");
                                Console.WriteLine("Quel est le nom du client que vous voulez supprimer :");
                                String TmpNom2 = Console.ReadLine();
                                Client ClientTrouve2 = CompteClients.FirstOrDefault(i => i.Nom == TmpNom2);
                                if (ClientTrouve2 == null)
                                {
                                    Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé le client que vous demandez");
                                }
                                else
                                {
                                    Console.WriteLine("Voici le client a supprimer :");
                                    Console.WriteLine(ClientTrouve2.AfficherClient());
                                    Console.WriteLine("Confirmer la suppression ? ( y / n ) :");
                                    // On récupère le choix de l'utilisateur
                                    ConfirmeSupp = Console.ReadKey(true);
                                    switch (ConfirmeSupp.KeyChar)
                                    {
                                        case 'y':
                                            ClientTrouve2.Compte = null;
                                            CompteClients.Remove(ClientTrouve2);
                                            Console.WriteLine("Compte client supprimé");
                                            break;
                                        default:
                                            Console.WriteLine("Compte client NON supprimé");
                                            break;
                                    }
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            #endregion

                            #region Permet de quitter le prohramme + test de frappe
                            case '9':
                                Console.WriteLine("\n\nMerci d'avoir utilisé notre programme, A+\n");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            default:
                                try
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                catch (ArgumentOutOfRangeException)
                                {

                                    Console.WriteLine("Erreur de saisie, merci de recommencer");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            #endregion
                        }

                    } while (Choix.KeyChar != '9');

                }
            } while (true);
        }
    }
}
