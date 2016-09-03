using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAdoTransaction
{
    class ProgramAdoTransaction
    {
        static void Main(string[] args)
        {
            // Préparation de la connection, création et ouverture de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";
            SqlConnection MyConnection = new SqlConnection(str);
            MyConnection.Open();

            // Création et début de la transaction
            SqlTransaction MyTransaction = MyConnection.BeginTransaction();


            // Début de notre try - Catch pour gérer notre transaction
            try
            {
                // Préparation de la Requete INSERT grâce à un objet SqlCommand
                SqlCommand MaRequete = new SqlCommand("INSERT INTO Personne(Nom,Prenom,Age,Email) VALUES ('SANNIER','Mylene',28,'mylene.sannier@hotmail.com')", MyConnection);

                // Ajout de la transcation sur l'opération Marequete
                MaRequete.Transaction = MyTransaction;

                // Execution de la command ou requete
                MaRequete.ExecuteNonQuery();

                // Validation de la transaction
                MyTransaction.Commit();
                Console.WriteLine("Personne insérée !!!!");
                Console.ReadKey();

            }
            catch // pour chaque exception reçu, le code dans le catch sera exécuté !!!!
            {
                
                // Annulation de la transaction !! il annule donc les opérations effectué !!!!
                MyTransaction.Rollback();
                Console.WriteLine("Erreur Personne non insérée !!!");
                Console.ReadKey();                
            }

            MyConnection.Close();

        }
    }
}
