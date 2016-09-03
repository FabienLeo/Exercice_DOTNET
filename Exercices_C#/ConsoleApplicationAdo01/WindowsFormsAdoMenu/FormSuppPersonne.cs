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
    public partial class FormSuppPersonne : Form
    {
        public FormSuppPersonne()
        {
            InitializeComponent();
            labelPersonneSupprime.Visible = false;
            labelErreurRechercheId.Visible = false;
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxEmail.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonRechercherId.Enabled = true;

            textBoxIdRecherche.Select();

            // Préparation du chemin de la connection
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BDDPersonne;Integrated Security=true";

            // Création de notre DataAdapter
            SqlDataAdapter MonDataAdapter = new SqlDataAdapter();

            // Creation de la commande pour lire la table à lire avec le like pour n'avoir que ce que l'on recherche
            MonDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Personne", new SqlConnection(str));

            // Creation du DataSet
            DataSet MonDataSetPersonne = new DataSet();

            // Remplissage de mon DataSet avec les données et la structure de la table Personne de ma BDD
            MonDataAdapter.Fill(MonDataSetPersonne, "personne");


            // Affichage de la table dans le gridview
            dataGridViewSupprimer.DataSource = MonDataSetPersonne.Tables[0];
        }

        private void buttonRechercherId_Click(object sender, EventArgs e)
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

            int TestTrouve = 0;

            foreach (DataRow DataRowAmodifier in MonDataSet.Tables["personne"].Select("id=" + textBoxIdRecherche.Text))
            {
                textBoxNom.Text = (string)DataRowAmodifier["nom"];
                textBoxPrenom.Text = (string)DataRowAmodifier["prenom"];
                textBoxAge.Text = DataRowAmodifier["age"].ToString();
                textBoxEmail.Text = (string)DataRowAmodifier["email"];
                buttonSupprimer.Enabled = true;
                TestTrouve = 1;
                buttonRechercherId.Enabled = false;
            }

            if (TestTrouve == 0)
            {
                labelErreurRechercheId.Visible = true;
            }
        }

        private void textBoxIdRecherche_TextChanged(object sender, EventArgs e)
        {
            buttonRechercherId.Enabled = true;
            labelErreurRechercheId.Visible = false;
            labelPersonneSupprime.Visible = false;
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAge.Clear();
            textBoxEmail.Clear();
            buttonSupprimer.Enabled = false;
            labelPersonneSupprime.Visible = false;
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            FormSuppPersonne.ActiveForm.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
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

            // Supprimer la ligne voulue
            // Fonctionne aussi ==> MonDataSet.Tables["personne"].Select("id=" + textBoxIdRecherche.Text)[0].Delete();

            foreach (DataRow MonDataRow in MonDataSet.Tables["personne"].Select("id=" + textBoxIdRecherche.Text))
            {
                MonDataRow.Delete();
            }

            labelPersonneSupprime.Visible = true;

            // Update de la BDD
            MonDataAdapter.Update(MonDataSet.Tables["personne"]);


            // Affichage de la table dans le gridview
            dataGridViewSupprimer.DataSource = MonDataSet.Tables[0];

            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAge.Clear();
            textBoxEmail.Clear();
            textBoxIdRecherche.Select();
            buttonSupprimer.Enabled = false;
            buttonRechercherId.Enabled = true;
        }

        private void FormSuppPersonne_Load(object sender, EventArgs e)
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



        }
    }
}
