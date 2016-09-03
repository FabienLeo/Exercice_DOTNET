using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteLibrary
{

    public interface ICompte 
    {

        // Solde est en lecture seul
        double Solde { get; }

        // Code est en lecture seul
        string Code { get; }

        double Montant { get; set; }

        void Depot(double montant);

        void Retirer(double montant);   
    
    }
    
        
    public abstract class Compte : ICompte
    {
        protected double solde;
        protected double montant;
        protected string code;

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

        public abstract void Depot(double montant);


        public abstract void Retirer(double montant);


    }

    public class Epargne : Compte 
    {
        private int tauxInteret = 6;
        //private double solde;

        public int TauxInteret
        {
            get { return tauxInteret; }
            set { tauxInteret = value; }
        }

        public override void Depot(double montant)
        {
            this.solde = this.solde + montant;
        }

        public override void Retirer(double montant)
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

    public class ComptePayant : Compte 
    {

        //private double solde;

        public override void Depot(double montant)
        {
            this.solde = this.solde + montant + 5;
        }

        public override void Retirer(double montant)
        {
            if ((this.solde - montant) < 0)
            {
                Console.WriteLine("RETRAIT IMPOSSIBLE T'ES TROP PAUVRE !!!!\n");
            }
            else
            {
                this.solde = this.solde - montant - 5;
            }
        }


    }
 

}
