using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySiteMarchand;
using System.Text.RegularExpressions;


namespace ClassLibrarySiteMarchand
{
    // Interface pour les class Client
    public interface IClient
    {

        string Nom { get; set; }

        string Prenom { get; set; }

        string Adresse { get; set; }

        DateTime DateNaissance { get; set; }

        string AdresseMail { get; set; }

        // Identifiant en lecture seul
        string IdPersonne { get; }

        // Méthode d'affichage des fiches clients
        string AfficherClient();
    }

    public class Client : IClient
    {

        private string prenom;
        private string nom;
        private string adresse;
        private DateTime dateNaissance;
        private string adresseMail;
        private string idPersonne;
        private Compte compte;
        private static int index;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string AdresseMail
        {
            get { return adresseMail; }
            set { adresseMail = value; }
        }

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }

        // Lecture seul avec incrémentation automatique ( NomP00 )
        public string IdPersonne
        {
            get
            {
                return idPersonne;
            }
        }


        // Constructeur des objets Client
        public Client(string nom, string prenom, DateTime dateNaissance, string adresse, string adresseMail, Compte Compte)
        {
            index++;

            if (dateNaissance.GetType() != typeof(DateTime))
            {
                throw new FormatException();
            }

            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.adresseMail = adresseMail;
            this.idPersonne = Convert.ToString(index.ToString("D4")) + "_" + this.nom + this.prenom.Substring(0, 1);
            this.compte = new Compte();
        }


        // Vérification de d'une adress Mail
        public static bool IsValideMail(string adresse) 
        {
            Regex Reg = new Regex("([^@\\s]+)@((?:[-a-z0-9]+\\.)+[a-z]{2,})");
            
            if (Reg.IsMatch(adresse))
            {
                return true;
            }
            else
            {
                throw new FormatException();
            }
        }

        // Vérification d'un adresse postale
        public static bool IsValideAdressePostale(string adresse)
        {
            Regex Reg = new Regex("[0-9]{1,3}(?:(?:[,. ]?){1}[-a-zA-Zàâäéèêëïîôöùûüç]+)*");

            if (Reg.IsMatch(adresse))
            {
                return true;
            }
            else
            {
                throw new FormatException();
            }
        }

        // Affichage d'une fiche Client
        public string AfficherClient()
        {
            StringBuilder MessageClient = new StringBuilder();
            MessageClient.AppendLine("\nFiche du client n° : " + this.idPersonne);
            MessageClient.AppendLine("\tNé(e) le " + this.dateNaissance.ToShortDateString());
            MessageClient.AppendLine("\tNom Prénom : " + this.prenom + " " + this.nom);
            MessageClient.AppendLine("\tAdresse : " + this.adresse);
            MessageClient.AppendLine("\tAdresse mail : " + this.adresseMail);
            MessageClient.AppendLine("\tIdentifiant Compte Associé : " + this.compte.Code);
            MessageClient.AppendLine("\tCréer le : " + this.compte.DateCreation.ToShortDateString());
            MessageClient.AppendLine("\tSolde de : " + this.compte.Solde);
            MessageClient.AppendLine("\tDépense effectué sur ce compte : " + this.compte.Depense);
            return MessageClient.ToString();
        }
    }
            
}
