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

namespace WindowsFormsAppADO
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // Récupération de la valeur dans le TextBox
            string NomRecherche = textBoxNom.Text;

            // Préparation du chemin de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";

            // Création de notre DataAdapter
            SqlDataAdapter MonDataAdapter = new SqlDataAdapter();

            // Création du parametre de la valeur du textbox + l'ajout du % pour finaliser la requete
            SqlParameter ParamTextBox = new SqlParameter("@textBox", NomRecherche+"%");


            // Creation de la commande pour lire la table à lire avec le like pour n'avoir que ce que l'on recherche
            MonDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Personne WHERE Nom LIKE @textBox", new SqlConnection(str)); 
            MonDataAdapter.SelectCommand.Parameters.Add(ParamTextBox);

            // Creation du DataSet
            DataSet MonDataSet = new DataSet();

            // Remplissage de mon DataSet avec les données et la structure de la table Personne de ma BDD
            MonDataAdapter.Fill(MonDataSet, "personne");


            // Affichage de la table dans le gridview
            dataGridViewPersonne.DataSource = MonDataSet.Tables[0];

        }


    }
}
