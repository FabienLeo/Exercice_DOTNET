using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySiteMarchand
{
    // Interface pour la Class de type Article
    public interface IArticle
    {

        string Name { get; set; }

        double Prix { get; set; }

        int Quantite { get; set; }

        string Categorie { get; set; }

        // Code est en lecture seul avec auto incrementation
        string IdArticle { get; }

        void Depot(int nombre); // Ajout d'un article dans sa quantité

        void Retirer(int nombre); // Suppression d'un article daprès l'achat d'un client

    }

    // Class artcile implémenté par l'interface IArticle
    public class Article : IArticle
    {

        private string name;
        private double prix;
        private int quantite;
        private string categorie;
        private string idArticle;
        private static int index;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        // Lecture seul avec creation auto de l'identifiant
        public string IdArticle
        {
            get{ return idArticle; }
        }

        // Constructeur pour Article
        public Article(string name, string categorie, double prix, int quantite)
        {
            index++;

            if (prix.GetType() != typeof(double))
            {
                throw new FormatException();
            }

            if (quantite < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            this.name = name;
            this.categorie = categorie;
            this.prix = prix;
            this.quantite = quantite;
            this.idArticle = Convert.ToString(index.ToString("D4")); // Création d'un identifiant unique pour l'objet article chaine de caractere de 4 caracteres
        }

        // Constructeur pour Article par defaut
        public Article()
        {
            index++;
            idArticle = Convert.ToString(index.ToString("D4")); // Création d'un identifiant unique pour l'objet article chaine de caractere de 4 caracteres
        }

        // Méthode permettant d'augmenter la quantite d'un article
        public void Depot(int nombre)
        {
            if (nombre < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if(nombre.GetType() != typeof(int))
            {
                throw new ArgumentException();                
            }
            
            this.quantite = this.quantite + nombre;
        }

        // Méthode permettant de modifier la quantité d'un article après l'achat d'un client par exemple
        public void Retirer(int nombre)
        {
            if ((this.quantite - nombre) < 0)
            {
                throw new Exception();
            }

            if (nombre < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if(nombre.GetType() != typeof(int))
            {
                throw new ArgumentException();                
            }

                this.quantite = this.quantite - nombre;
        }

        // Méthode d'affichage d'un article
        public string AfficherArticle()
        {
            StringBuilder MessageArticle = new StringBuilder();
            MessageArticle.AppendLine("\nArticle n° : " + this.idArticle);
            MessageArticle.AppendLine("\tNom : " + this.name);
            MessageArticle.AppendLine("\tCatégorie : " + this.categorie);
            MessageArticle.AppendLine("\tPrix de vente : " + this.prix);
            MessageArticle.AppendLine("\tQuantité restante : " + this.quantite);
            return MessageArticle.ToString();
        }

    }
}
