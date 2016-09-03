using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySiteMarchand;

namespace ClassLibrarySiteMarchand
{
    // Interface pour les class Compte
    public interface ICompte
    {

        // Solde est en lecture seul
        double Solde { get; }

        // Code est en lecture seul
        string Code { get; }

        double Depense { get; set; }

        // Date de creation est en lecture seul
        DateTime DateCreation { get; }

        void Depot(double montant); 

        void Retirer(double montant);   

        void CadeauAnniversaire(Client client);

        double Discount();

        string AfficherCompte();

    }



    // Définition de la Class Compte implémenté par l'interface ICompte
    public class Compte : ICompte
    {
        private double solde;
        private double depense;
        private string code;
        private DateTime dateCreation;
        private static int indexCompte;


        // Solde est en lecture seul
        public double Solde
        {
            get { return solde; }
        }

        // Code est en lecture seul
        public string Code
        {
            get { return code; }
        }

        public double Depense
        {
            get { return depense; }
            set { depense = value; }
        }

        // Date de creation du compte en lecture seul
        public DateTime DateCreation
        {
            get { return dateCreation; }
        }

        // Constructeur par défaut avec génération du code compte en correspondance avec 1 client.
        public Compte()
        {
            indexCompte++;
            this.code = indexCompte.ToString("D4"); // Creation d'un identifiant unique pour chaque compte de 4 caractères
            this.dateCreation = DateTime.Today;
        }

        // Méthode de dépot d'argent sur le solde du compte
        public void Depot(double montant)
        {
            this.solde = this.solde + montant;
        }

        // Méthode de retrait d'argent sur le solde du compte avec test des fonds disponible sur le compte
        public void Retirer(double montant)
        {
            if ((this.solde - montant) < 0)
            {
                Console.WriteLine("RETRAIT IMPOSSIBLE, pas assez de fond disponible !!!!\n");
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.solde = this.solde - montant;
            }
        }


        // Créditer le compte du client avec un cadeau de 10 euros ou 10 euros + 1% si plus de 1000 euros de depense pour son anniversaire
        public void CadeauAnniversaire(Client client)
        {
            if (DateTime.Now.ToString("m") == client.DateNaissance.ToString("m"))
            {
                if (this.depense < 1000)
                {
                    this.solde += 10;       // Ajout de 10 euros sur le du client pour son anniversaire
                }
                else
                {
                    this.solde = this.solde + 10 + (this.depense * 1 / 100); // ajout d'un cadeau de 10 + 1% du total de dépense
                }
            }
        }


        // Calcul du pourcentage de réduction en fonction de l'anciente du compte.
        public double Discount()
        {
            int anciente = DateTime.Now.Year - this.dateCreation.Year;
            double poucentageReduc = anciente * 2 / 100;
            return poucentageReduc;
        }

        // Methode d'affichage des information d'un compte
        public string AfficherCompte()
        {
            StringBuilder MessageCompte = new StringBuilder();
            MessageCompte.AppendLine("\nCompte Bancaire n° : " + this.code);
            MessageCompte.AppendLine("\tCréer le : " + this.dateCreation.ToShortDateString());
            MessageCompte.AppendLine("\tSolde de : " + this.solde);
            MessageCompte.AppendLine("\tDépense effectué sur ce compte : " + this.depense);
            return MessageCompte.ToString();
        }
    }
}
