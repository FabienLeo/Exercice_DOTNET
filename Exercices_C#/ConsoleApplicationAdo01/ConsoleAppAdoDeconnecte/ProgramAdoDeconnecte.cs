using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAdoDeconnecte
{
    class ProgramAdoDeconnecte
    {
        static void Main(string[] args)
        {
            // Objectif : Afficher la struicture de la BDD récupérée

            // Préparation du chemin de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";
            
            // Création de notre DataAdapter
            SqlDataAdapter MonDataAdapter = new SqlDataAdapter();

            // Creation de la commande pour lire la table à lire
            MonDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Personne", new SqlConnection(str));
            
            // Creation du DataSet
            DataSet MonDataSet = new DataSet();

            // Remplissage de mon DataSet avec les données et la structure de la table Personne de ma BDD
            MonDataAdapter.Fill(MonDataSet, "personne");

            // Affichage de la structure de ma table personne et voir que l'on a bien récupérer les données et la structure de la BDD
            Console.WriteLine("Table {0}", MonDataSet.Tables[0].TableName);

            foreach (DataColumn MaDateColonne in MonDataSet.Tables[0].Columns)
            {
                Console.WriteLine("\tColonne : {0} ==> Type : {1}", MaDateColonne.ColumnName, MaDateColonne.DataType.Name);
            }


            Console.WriteLine(""); // Saut d'une ligne

            // Creation et affectation des commandes a associer à notre DataAdapter
            SqlCommandBuilder MaCommandeBuilder = new SqlCommandBuilder(MonDataAdapter);

            // Affichage des methodes possibles, juste pour savoir ce que il y dans un SqlCommandBuilder
            Console.WriteLine("Update : " + MaCommandeBuilder.GetUpdateCommand().CommandText + "\n");
            Console.WriteLine("Insert : " + MaCommandeBuilder.GetInsertCommand().CommandText + "\n");
            Console.WriteLine("Delete : " + MaCommandeBuilder.GetDeleteCommand().CommandText + "\n");
         

            // Lire les informations dans le DataSet
            // On affiche les en-tête des colonnes
            foreach (DataColumn MonDataColonne in MonDataSet.Tables[0].Columns)
            {
                Console.Write(" {0}", MonDataColonne.ColumnName);   
            }
            Console.WriteLine("\n---------------------------------------\n");

            // On affiche les valeurs de chaque CASE de la TABLE, donc on va sur chaque ligne puis sur chaque colonne pour récupérer les valeurs
            foreach (DataRow MonDataLigne in MonDataSet.Tables[0].Rows)
            {
                foreach (DataColumn MonDataColonne in MonDataSet.Tables[0].Columns)
                {
                    Console.Write(" " + MonDataLigne[MonDataColonne.ColumnName]); // Attention Write et non WriteLine afin d'afficher en ligne les infos
                }
                Console.WriteLine(); // Saut d'une ligne
            }

            Console.ReadKey();
            
            
            // Ajouter une personnne au DataSet
            //DataRow MaDataRow = MonDataSet.Tables[0].NewRow();
            //MaDataRow["nom"] = "BARON";
            //MaDataRow["prenom"] = "Jeremie";
            //MaDataRow["age"] = "32";
            //MaDataRow["email"] = "jeremie.baron@gmail.com";
           
            // Ajout de la ligne ( row ) au DataSet
            //MonDataSet.Tables[0].Rows.Add(MaDataRow);

            // Mise à jour de la TABLE dans la base de données
            // MonDataAdapter.Update(MonDataSet.Tables[0]);

            //Console.WriteLine("Personne Ajouté !!!");

            // Mise a jour de la personne connaisasnt la ligne
            MonDataSet.Tables[0].Rows[0]["prenom"] = "ModifPrenom";
            MonDataAdapter.Update(MonDataSet.Tables[0]);
            Console.WriteLine("Personne Modifié");

            // update avec une condition
            foreach (DataRow MonDataRow in MonDataSet.Tables[0].Select("id="+5))
            {
                MonDataRow["prenom"] = "testmodifcond";
                MonDataRow["age"] = 75;

            }
            Console.WriteLine("Personne Modifié");


            Console.ReadKey();

        }
    }
}
