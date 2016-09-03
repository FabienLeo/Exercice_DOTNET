using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAdo02
{
    class Program02
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
            SqlCommand MaRequeteParametre = new SqlCommand("SELECT * FROM Personne WHERE Nom LIKE @param", MyConnection);

            // Valorisation du paramètre
            SqlParameter MonParametre = new SqlParameter("@param","d%"); // Les personnes commence par d
            
            // Passage du Paramètre à la commande
            MaRequeteParametre.Parameters.Add(MonParametre);

            // Récupération du résultat grâce à un objet SqlDataReader et execution de la requete
            SqlDataReader MonResultat = MaRequeteParametre.ExecuteReader();

            // Affichage du résultat sur la console

            while (MonResultat.Read())
            {
                Console.WriteLine(MonResultat.GetString(1) + " " + MonResultat["Prenom"]);
            }

            Console.ReadKey();


            // Fermeture de la connection et recupération de l'espace de DataReader
            MonResultat.Close();
            MyConnection.Close();


        }
    }
}
