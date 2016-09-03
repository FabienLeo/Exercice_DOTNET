using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockLibrary
{
    public class Article
    {
        private int refArticle;
        private string nom;
        private double prixVente;
        private int quantite;

        public int RefArticle
        {
            get { return refArticle; }
            set { refArticle = value; }
        }

        public string Nom
	    {
		    get { return nom;}
		    set { nom = value;}
	    }

        public double PrixVente
        {
            get { return prixVente; }
            set { prixVente = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        // Constructeur d'initialisation
        public Article(int refArticle, string nom, double prixVente, int quantite) 
        {
            this.refArticle = refArticle;
            this.nom = nom;
            this.prixVente = prixVente;
            this.quantite = quantite;
        }

        // Constructeur d'initialisation par defaut
        public Article() { }

        public void ToString(int refArticle, string nom, double prixVente, int quantite) 
        {
            Console.WriteLine("==> Ref :" + refArticle + "\t Nom :" + nom + "\t Prix :" + prixVente + " euros \t Qte :" + quantite);
        }
    }
}
