using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteLibrary
{

    public interface ICompte 
    {

        private double solde;
        double montant;
        string code;

        void Depot(double montant) { }

        void Retirer(double montant) { }

    
    
    
    }
    
        
    public class Compte : ICompte
    {
        private double solde;
        private double montant;
        private string code;

        // Solde est en lecture seul
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        // Code est en lecture seul
        public string Code
        {
            get { return code;}
            //set { code = value; }
        }

        public double Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        // Constructeur par défaut avec génération du code aléatoire
        public Compte()
        {        
            this.code = Guid.NewGuid().ToString();
            this.code = code.Substring(0, 5);
        }

        public void Depot(double montant)
        {
        this.solde = this.solde + montant;
        }

        public void Retirer(double montant)
        {

            if ((this.solde - montant) < 0) 
            {
                Console.WriteLine("RETRAIT IMPOSSIBLE T'ES TROP PAUVRE !!!!\n");
            }
            else 
            { 
                this.solde = this.solde - montant;
            }
           
        }

    }

    public class Epargne : Compte 
    {
        private int tauxInteret = 6;

        public int TauxInteret
        {
            get { return tauxInteret; }
            set { tauxInteret = value; }
        }

    }

    public class CoptePayant : Compte 
    {
    // Override des fonction afin de rajouter le coup de 5 euros a chaque fois


    }
}
