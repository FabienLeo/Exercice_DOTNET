using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplicationAdo01
{
    class Program01
    {
        static void Main(string[] args)
        {

            // Préparation de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";

            // Création de la connection grâce a l'instanciation d'un objet SqlConnection
            SqlConnection MyConnection = new SqlConnection(str);

            // Ouverture de la connection
            MyConnection.Open();

            // Préparation de la commande Requete grâce à un objet SqlCommand
            SqlCommand MaRequete = new SqlCommand("SELECT * FROM Personne", MyConnection);

            // Récupération du résultat grâce à un objet SqlDataReader
            SqlDataReader MonResultat = MaRequete.ExecuteReader();

            // Affichage du résultat sur la console

            while (MonResultat.Read())
            {
                Console.WriteLine(MonResultat.GetString(1) + " " + MonResultat["Prenom"]); // Deux emple de lecture du resultat ( DataReader )
            }

            Console.ReadKey();


            // Fermeture de la connection et recupération de l'espace de DataReader
            MonResultat.Close();
            MyConnection.Close();
        }
    }
}
