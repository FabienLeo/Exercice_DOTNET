using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStockLibrary;

namespace GestionStock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Création des variable locales
            ConsoleKeyInfo Choix;
            
            // Création de la collection d'articles
            List<Article> MonCatalogue = new List<Article>();

            //Creation des articles initiaux du catalogue
            MonCatalogue.Add(new Article() { RefArticle = 01, Nom = "Ecran Ordinateur", PrixVente = 124.55, Quantite = 100 });
            MonCatalogue.Add(new Article() { RefArticle = 02, Nom = "ordinateur", PrixVente = 1240.75, Quantite = 200 });
            MonCatalogue.Add(new Article() { RefArticle = 03, Nom = "Clavier", PrixVente = 89.20, Quantite = 10 });
            MonCatalogue.Add(new Article() { RefArticle = 04, Nom = "Souris", PrixVente = 24.55, Quantite = 10 });
     

            do
            {

            //Question posée à l'utilisateur, on récupère la valmeur de la touche appuyé
            Console.WriteLine("\nMenu Principal: \n" + 
                              "\t\t1 - Rechercher un Article par ref\n" +
                              "\t\t2 - Ajouter un Article\n" +
                              "\t\t3 - Supprimer un Artcile\n" +
                              "\t\t4 - Modifier un Article\n" +
                              "\t\t5 - Rechercher un Article par nom\n" +
                              "\t\t6 - Rechercher un Article par intervalle de prix\n" +
                              "\t\t7 - Afficher tous les articles\n" +
                              "\t\t9 - Quittez le programme\n\n" +
                              "Votre choix :");

            // On récupère le choix de l'utilisateur
            Choix = Console.ReadKey(true);
            Console.Clear();
                
            // On défini les différents comportement en fonction du choix récupéré
            switch (Choix.KeyChar)
            {
                // recherche d'un article par Référence
                case '1':
                    Console.WriteLine("Recherche d'un article par Référence\n\n");
                    Console.WriteLine("Quelle référence recherchez vous :");
                    int TmpRef = Convert.ToInt32(Console.ReadLine());
                    Article ArticleTrouve = MonCatalogue.FirstOrDefault(i => i.RefArticle == TmpRef);
                    if (ArticleTrouve == null)
                    {
                        Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                    }
                    else 
                    {
                        Console.WriteLine("Voici l'article avec la référence : " + ArticleTrouve.RefArticle);
                        ArticleTrouve.ToString(ArticleTrouve.RefArticle,ArticleTrouve.Nom,ArticleTrouve.PrixVente,ArticleTrouve.Quantite);
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;
                
                // Ajout d'un Article dans le catalogue
                case '2':
                    Console.WriteLine("Ajout d'un Article dans le catalogue\n\n");
                    Console.WriteLine("Référence de l'Article :");
                    int TmpRefAjout = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom de l'Article :");
                    String TmpNom = Console.ReadLine();

                    Console.WriteLine("Prix de l'Article :");
                    double TmpPrix = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Quantité de l'Article :");
                    int TmpQte = Convert.ToInt32(Console.ReadLine());
                
                    // A FAIRE Control de la saisie de l'utilisateur ???
                    MonCatalogue.Add( new Article(TmpRefAjout,TmpNom,TmpPrix,TmpQte));
                    Console.WriteLine("Article ajouté !!!");


                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Suppression d'un article par référence
                case '3':
                    Console.WriteLine("Suppression d'un article par référence\n\n");
                    Console.WriteLine("Quel est la référence de l'article que vous voulez supprimer :");
                    int TmpRefSupp = Convert.ToInt32(Console.ReadLine());
                    Article ArticleTrouve2 = MonCatalogue.FirstOrDefault(i => i.RefArticle == TmpRefSupp);
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

                // Modifier l'article par référence
                case '4':
                    Console.WriteLine("Modifier l'article par référence\n\n");
                    Console.WriteLine("Quel est la référence de l'article que vous voulez modifier :");
                    int TmpRefModif = Convert.ToInt32(Console.ReadLine());
                    Article ArticleTrouve3 = MonCatalogue.FirstOrDefault(i => i.RefArticle == TmpRefModif);
                    if (ArticleTrouve3 == null)
                    {
                        Console.WriteLine("Cette référence n'existe pas, nous ne pouvons pas modifier l'article correspondant");
                    }
                    else
                    {
                        MonCatalogue.Remove(ArticleTrouve3);
                        Console.WriteLine("Modifier la eéférence de l'Article " + ArticleTrouve3.RefArticle +" par :");
                        int TmpRefAjout2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Modifier le nom de l'Article " + ArticleTrouve3.Nom + " par :");
                        String TmpNom2 = Console.ReadLine();

                        Console.WriteLine("Modifier le prix de l'Article " + ArticleTrouve3.PrixVente + " par :");
                        double TmpPrix2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Modifier la Quantité de l'Article " + ArticleTrouve3.Quantite + " par :");
                        int TmpQte2 = Convert.ToInt32(Console.ReadLine());

                        // A FAIRE Control de la saisie de l'utilisateur ???
                        MonCatalogue.Add(new Article(TmpRefAjout2, TmpNom2, TmpPrix2, TmpQte2));
                    
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Recherche d'un article par Nom
                case '5':
                    Console.WriteLine("Recherche d'un article par Nom\n\n");
                    Console.WriteLine("Quel est l'article que vous cherchez :");
                    String TmpNom3 = Console.ReadLine();
                    Article ArticleTrouve4 = MonCatalogue.FirstOrDefault(i => i.Nom == TmpNom3);
                    if (ArticleTrouve4 == null)
                    {
                        Console.WriteLine("Nous sommes désolé, nous n'avons pas trouvé l'article que vous demandez");
                    }
                    else 
                    {
                        Console.WriteLine("Voici l'article avec le Nom " + ArticleTrouve4.Nom + " :");
                        ArticleTrouve4.ToString(ArticleTrouve4.RefArticle,ArticleTrouve4.Nom,ArticleTrouve4.PrixVente,ArticleTrouve4.Quantite);
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;
                
                // Rechercher un article par intervalle de prix
                case '6':
                    Console.WriteLine("Recherche d'un article par intervalle de prix de vente\n\n");
                    Console.WriteLine("Quel est le prix de départ de votre intervalle :");
                    Double TmpPrixStart = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Quel est le prix de fin de votre intervalle :");
                    Double TmpPrixEnd = Convert.ToDouble(Console.ReadLine());

                    foreach (Article ArticleTrouvePrix in MonCatalogue)
                    {
                        if (ArticleTrouvePrix.PrixVente >= TmpPrixStart)
                        {
                            if (ArticleTrouvePrix.PrixVente <= TmpPrixEnd)
                            {
                                ArticleTrouvePrix.ToString(ArticleTrouvePrix.RefArticle, ArticleTrouvePrix.Nom, ArticleTrouvePrix.PrixVente, ArticleTrouvePrix.Quantite);
                            }
                        }
                    }       
                 
                    
                    Console.ReadKey();
                    Console.Clear();
                    break;
                
                // Affichage de tous les articles du catalogue
                case '7':
                    Console.WriteLine("Affichage de tous les articles du catalogue\n\n");
                    for (int i = 0; i < MonCatalogue.Count ; i++) 
                    {
                        MonCatalogue[i].ToString(MonCatalogue[i].RefArticle, MonCatalogue[i].Nom, MonCatalogue[i].PrixVente, MonCatalogue[i].Quantite);
                    }
                      
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
                // Permet de quitter le prohramme
                case '9':
                    Console.WriteLine("\n\nMerci d'avoir utilisé notre programme, A+\n");
                    break;

                default:
                    Console.WriteLine("\n\nERREUR SAISI CHOIX MENU\n\n");

                    Console.ReadKey();
                    Console.Clear();
                    break;
            }



            } while (Choix.KeyChar != '9' );            

            Console.ReadKey();

        }
    }
}
