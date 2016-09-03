using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetEntityFrameworkCodeFirst.Dao;
using ProjetEntityFrameworkCodeFirst.Metier;

namespace ProjetEntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            // déclaration de l'interface utilisé pour appeler les méthodes
            IDao I = new DaoImpl();

            Console.WriteLine("Quel est le nom :");
            string NomSaisie = Console.ReadLine();

            Console.WriteLine("Quel est le prénom :");
            string PrenomSaisie = Console.ReadLine();

            Console.WriteLine("Quel age :");
            int AgeSaisie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quel est l'email :");
            string EmailSaisie = Console.ReadLine();

            Personne p = new Personne { Nom = NomSaisie, Prenom = PrenomSaisie, Age = AgeSaisie, Email = EmailSaisie, idAdresse=1 };

            I.AjouterPersonne(p);


            Console.WriteLine("Personne AJOUTE !!!!!   ;)");

            Console.ReadKey();

        }
    }
}
