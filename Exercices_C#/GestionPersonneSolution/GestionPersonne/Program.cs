using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AffichePersonne; // On utilise le namespace AffichePersonne du fichier dll Personne

namespace GestionPersonne
{
    class Program
    {

              static void Main(string[] args)
        {

            Personne MaPersonne = new Personne();   //Création de l'objet de type Personne

            Console.WriteLine( "Quel est ton Age ?");   // Affichage de la question

            MaPersonne.Age = Convert.ToInt32(Console.ReadLine());   // Récupération de la valeur avec une convertion
                  
            Console.WriteLine(" Quel est ton Prénom ?");
                  MaPersonne.Prenom = Console.ReadLine();

            Console.WriteLine(" Quel est ton Nom ?");
                  MaPersonne.Nom = Console.ReadLine();


            Personne MaPersonneAvecConstructeur = new Personne(12, "DUPONT", "Alain");


            Personne.Afficher(MaPersonne);
            Personne.Afficher(MaPersonneAvecConstructeur);

                  
// test de la boucle for
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Ligne " + i + " : " + " Fabien est trop fort !!!");
            }

// test de la bouce foreach
            string[] ListeMots = {"mot1","mot2","mot3","mot4","mot5","mot6","mot7"};
            foreach (string mot in ListeMots)
            {
                Console.WriteLine(mot);
            }

// test de la boucle while
            string reponse = "oui";
            while (reponse=="oui")
            {
                Console.WriteLine("Voulez vous continuer ?\n");
                reponse = Console.ReadLine();
                
            }

// test de la boucle for avec récupération la valeur lenght du tableau
            string[] Tableau = {"1","2","3","4"};
            for (int i = 0; i < Tableau.Length ; i++)
            {
                Console.WriteLine("Valeur de la Case " + i + " : " + Tableau[i]);  
            }

            Console.ReadKey();
              
         }
    }
}
