using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabienLibrary; // Attention, ne pas oublier d'ajouter la library que l'on vient de créer

namespace PolyMorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des différentes variable Date
            DateTime Date_01 = Convert.ToDateTime("12/12/1985");
            DateTime Date_02 = Convert.ToDateTime("14/01/1987");
            DateTime Date_03 = Convert.ToDateTime("20/05/1975");
            DateTime Date_04 = Convert.ToDateTime("06/05/1984");
            DateTime Date_05 = Convert.ToDateTime("16/07/1976");
            DateTime Date_06 = Convert.ToDateTime("24/02/1987");
            DateTime Date_07 = Convert.ToDateTime("19/09/1952");
            DateTime Date_08 = Convert.ToDateTime("26/01/1956");

            // Déclaration des différents élément de mon tableau 
            Employe Employe_01 = new Employe(Date_01,"BRUNEAU","François",1542.12);
            Employe Employe_02 = new Employe(Date_02,"BERTHELOT","Pierre",1142.12);
            Employe Employe_03 = new Employe(Date_03,"LABAUME","Gregory",2542.12);
            Employe Employe_04 = new Employe(Date_04,"BASSET","Cécile",1642.12);
            Employe Employe_05 = new Employe(Date_05,"BRUNEAU","François",1542.12);
            Chef Chef_01 = new Chef(Date_06,"BOURASSIN","Clément",2541.25,"Aéronautique");
            Chef Chef_02 = new Chef(Date_07,"SANNIER","Mylène",2598.2,"Animalier");
            Directeur Directeur_01 = new Directeur(Date_08,"GAUDRON","Fabien",3025.45,"Direction Générale","LeoProd");

            // Création du tableau avec les éléments que j'ai créé précédemment
            Personne[] TablePersonne = { Employe_01, Employe_02, Employe_03, Employe_04, Employe_05, Chef_01, Chef_02, Directeur_01 };

            // Affichage des différents éléments grâce à une boucle for
            for (int i = 0; i < TablePersonne.Length; i++)
            {
                TablePersonne[i].Afficher();
            }

            // Affichage des différents éléments grâce à une boucle foreach
            foreach (Personne Elem in TablePersonne)
            {
                Elem.Afficher();
            }

            // Attente de l'appui d'une touche
            Console.ReadKey();

        }
    }
}
