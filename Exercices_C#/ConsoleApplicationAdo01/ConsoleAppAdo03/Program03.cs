using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAdo03
{
    class Program03
    {
        static void Main(string[] args)
        {
            // Préparation de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";

            // Création de la connection grâce a l'instanciation d'un objet SqlConnection
            SqlConnection MyConnection = new SqlConnection(str);

            // Ouverture de la connection
            MyConnection.Open();

            // Préparation de la Requete grâce à un objet SqlCommand et un parameter
            SqlCommand MaRequeteParametre = new SqlCommand("SELECT * FROM Personne WHERE Nom LIKE @param1 AND email LIKE @param2", MyConnection);

            // Valorisation du paramètre
            SqlParameter MonParametre1 = new SqlParameter("@param1", "%t"); // Les personnes avec un nom se terminant par t
            SqlParameter MonParametre2 = new SqlParameter("@param2", "%gmail%"); // Les personnes avec une adresse gmail

            // Passage du Paramètre à la commande
            MaRequeteParametre.Parameters.Add(MonParametre1);
            MaRequeteParametre.Parameters.Add(MonParametre2);

            // Récupération du résultat grâce à un objet SqlDataReader et execution de la requete
            SqlDataReader MonResultat = MaRequeteParametre.ExecuteReader();

            // Affichage du résultat sur la console

            while (MonResultat.Read())
            {
                Console.WriteLine(MonResultat["Nom"] + " " + MonResultat["Prenom"] + " ==> " + MonResultat["email"]);
            }

            Console.ReadKey();


            // Fermeture de la connection et recupération de l'espace de DataReader
            MonResultat.Close();
            MyConnection.Close();

        }
    }
}
