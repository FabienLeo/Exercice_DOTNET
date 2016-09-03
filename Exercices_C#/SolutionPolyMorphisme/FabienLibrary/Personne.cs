using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabienLibrary
{
    public class Personne
    {
        private DateTime dateNaissance;
        private string nom;
        private string prenom;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value;}
        }
       
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
     
        // Constructeur de la Class Personne avec Arguments
        public Personne(DateTime dateNaissance, string nom, string prenom) 
        {
            this.dateNaissance = dateNaissance;
            this.nom = nom;
            this.prenom = prenom;        
        }

        // Constructeur par défaut de la Class Personne
        public Personne() { }
        
        // Méthode de la class Personne qui permet d'affiche dans la console la fiche Personne
        public virtual void Afficher()
        {
        
            Console.WriteLine("\n Voici la fiche de " + prenom + " " + nom + " :\n" 
            + " Nom : " + nom + "\n"
            + " Prénom : " + prenom + "\n"
            + " Date de Naissance : " + dateNaissance.Day + "/" + dateNaissance.Month + "/" + dateNaissance.Year );

        }

        
    }

    public class Employe : Personne 
    {
        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        // constructeur de la classe Employé dérivé de la class mere Personne
        public Employe(DateTime dateNaissance, string nom, string prenom,double salaire)
                      :base (dateNaissance,nom,prenom) 
        {
            this.salaire = salaire;      
        }

        // Constructeur par defaut
        public Employe() { }   
     
        // Méthode de la Class Employé qui permet d'afficher dans la console la fiche Employé
        public override void Afficher()
        {
        base.Afficher();
        Console.WriteLine(" Salaire : " + salaire + " euros" );
        }
    
    }

    public class Chef : Employe 
    {

        private string service;

        public string Service
        {
            get { return service; }
            set { service = value; }
        }

        // constructeur de la classe Chef dérivé de la class mere Employe:Personne
        public Chef(DateTime dateNaissance, string nom, string prenom,double salaire,string service)
                      :base (dateNaissance,nom,prenom,salaire) 
        {
            this.service = service;      
        }

        // Constructeur par defaut
        public Chef() { }

        // Méthode de la Class Chef qui permet d'afficher dans la console la fiche Chef
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(" Service : " + service);
        }
    
    }

    public class Directeur : Chef 
    {

        private string societe;

        public string Societe
        {
            get { return societe; }
            set { societe = value; }
        }

        // constructeur de la classe Directeur dérivé de la class mere Chef:Employe:Personne
        public Directeur(DateTime dateNaissance, string nom, string prenom,double salaire,string service,string societe)
                      :base (dateNaissance,nom,prenom,salaire,service) 
        {
            this.societe = societe;      
        }

        // Constructeur par defaut
        public Directeur() { }

        // Méthode de la Class Directeur qui permet d'afficher dans la console la fiche Directeur
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(" Société : " + societe );
        }

    }

}
