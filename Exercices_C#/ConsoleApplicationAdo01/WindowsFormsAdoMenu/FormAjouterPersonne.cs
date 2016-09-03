using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdoMenu
{
    public partial class FormAjouterPersonne : Form
    {
        public FormAjouterPersonne()
        {
            InitializeComponent();
            labelPersonneAjouter.Visible = false;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

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

                // Creation et affectation des commandes a associer à notre DataAdapter
                SqlCommandBuilder MaCommandeBuilder = new SqlCommandBuilder(MonDataAdapter);



                // Ajouter une personnne au DataSet
                DataRow MaDataRow = MonDataSet.Tables[0].NewRow();
                MaDataRow["nom"] = textBoxNom.Text;
                MaDataRow["prenom"] = textBoxPrenom.Text;
                MaDataRow["age"] = textBoxAge.Text;
                MaDataRow["email"] = textBoxEmail.Text;

                // Ajout de la ligne ( row ) au DataSet
                MonDataSet.Tables[0].Rows.Add(MaDataRow);

                // Mise à jour de la TABLE dans la base de données
                MonDataAdapter.Update(MonDataSet.Tables[0]);
                labelPersonneAjouter.Visible = true;
                textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxAge.Clear();
                textBoxEmail.Clear();
                labelPersonneAjouter.Show();





        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            labelPersonneAjouter.Visible = false;
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            FormAjouterPersonne.ActiveForm.Close();
        }


    }
}
