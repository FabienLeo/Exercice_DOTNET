using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequeteLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Source de données 
            int[] Data = new int[] { 80, 41, 43, 43, 44, 50, 46 };




            // Equivalent LINQ de la requete SQL : SELECT * FROM Data
            IEnumerable<int> Req01 = from num in Data
                                     select num;
            // Affiche résultat
            foreach (var n in Req01)
            {
                Console.WriteLine("Req01 : {0}",n);
            }



            // Equivalent LINQ de la requete SQL : SELECT * FROM Data WHERE Num > 43
            IEnumerable<int> Req02 = from num in Data
                                     where num > 43
                                     select num;
            // Affiche résultat
            foreach (var n in Req02)
            {
                Console.WriteLine("Req02 : {0}", n);
            }

            // Equivalent LINQ de la requete SQL : SELECT * FROM Data WHERE Num > 43
            IEnumerable<int> Req03 = from num in Data
                                     orderby num descending
                                     select num;
            // Affiche résultat
            foreach (var n in Req03)
            {
                Console.WriteLine("Req03 : {0}", n);
            }
                        
            Console.WriteLine("");


            // création de la liste de personne

            IList<Personne> personnes = new List<Personne>
            {
            new Personne{idPersonne = 1, Nom = "GAUDRON", Prenom = "Fabien", Age= 33},
            new Personne{idPersonne = 2, Nom = "BERTHELOT", Prenom = "Pierre", Age= 32},
            new Personne{idPersonne = 3, Nom = "LABAUME", Prenom = "Greg", Age= 28},
            new Personne{idPersonne = 4, Nom = "SANNIER", Prenom = "Mylène", Age= 21},
            new Personne{idPersonne = 5, Nom = "BARON", Prenom = "Jeremie", Age= 45},
            new Personne{idPersonne = 6, Nom = "BOURASSIN", Prenom = "Clément", Age= 18},

            };


            // Liste de personne ayant plus de 30 ans et affichage par ordre croisssant du Nom avec la methode QUERY SYNTAXE
            Console.WriteLine("QUERY SYNTAXE");
            var Req04 = from p in personnes
                        where p.Age > 30
                        orderby p.Nom ascending
                        select p;

            foreach (var m in Req04)
            {
                Console.WriteLine("Nom = {0}, Prénom = {1}, Age = {2}", m.Nom,m.Prenom,m.Age);
            }

            Console.WriteLine("");

            // Liste de personne ayant plus de 30 ans et affichage par ordre croisssant du Nom avec la methode SYNTAXE
            Console.WriteLine("METHOD SYNTAXE");
            var Req05 = personnes
                            .Where(p => p.Age > 30)
                            .OrderBy(p => p.Nom)
                            .ToList();



            foreach (var m in Req05)
            {
                Console.WriteLine("Nom = {0}, Prénom = {1}, Age = {2}", m.Nom, m.Prenom, m.Age);
            }


            Console.ReadKey();








        }
    }
}
