using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffichePersonne
{
    public class Personne
    {


        private int age;
        private string prenom;
        private string nom;

        public int Age
        {
            get { return age; }
            set
            {

                if (value < 0)          // test des valeur négative affecté à la variable age
                {
                    age = value * -1;   // On rend la valeur positive
                    Console.WriteLine("\n Les valeurs Négative sont incorrecte !!! \n");
                }
                else
                {
                    age = value;
                }
            }
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

        public Personne(int age, string nom, string prenom)
        {
            this.age = age;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Personne()
        {

        }

        public static void Afficher(Personne TempPersonne)
        {



            Console.WriteLine("\n" + "Tu as " + TempPersonne.age + " ans");
            Console.WriteLine("Tu t'apelles " + TempPersonne.prenom + " " + TempPersonne.nom + "\n");

            Console.ReadKey();

        }
    }
}
