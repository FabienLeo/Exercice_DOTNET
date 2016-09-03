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
    public partial class FormModifierPersonne : Form
    {
        public FormModifierPersonne()
        {
            InitializeComponent();
            labelPersonneModifier.Visible = false;
            labelErreurRechercheId.Visible = false;
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxEmail.Enabled = false;
            buttonModifier.Enabled = false;

            textBoxIdRecherche.Select();
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

            foreach (DataRow DataRowAmodifier in MonDataSet.Tables["personne"].Select("id="+textBoxIdRecherche.Text))
	            {
		            textBoxNom.Text = (string)DataRowAmodifier["nom"];
                    textBoxPrenom.Text = (string)DataRowAmodifier["prenom"];
                    textBoxAge.Text = DataRowAmodifier["age"].ToString();
                    textBoxEmail.Text = (string)DataRowAmodifier["email"];
                    textBoxNom.Enabled = true;
                    textBoxPrenom.Enabled = true;
                    textBoxAge.Enabled = true;
                    textBoxEmail.Enabled = true;
                    buttonModifier.Enabled = true;
                    buttonRechercherId.Enabled = false;
                    TestTrouve = 1;
	            }
            
            if(TestTrouve == 0)
            {
                labelErreurRechercheId.Visible = true;
            }



        }

        private void textBoxIdRecherche_TextChanged(object sender, EventArgs e)
        {
            labelErreurRechercheId.Visible = false;
            labelPersonneModifier.Visible = false;
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAge.Clear();
            textBoxEmail.Clear();
            buttonModifier.Enabled = false;
            buttonRechercherId.Enabled = true;
            labelPersonneModifier.Visible = false;
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            FormModifierPersonne.ActiveForm.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
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

            // On modifie la ligne qui correspond au souhait de l'utilisateur
            foreach (DataRow DataRowAmodifier in MonDataSet.Tables["personne"].Select("id=" + textBoxIdRecherche.Text))
            {
                DataRowAmodifier["nom"] = textBoxNom.Text;
                DataRowAmodifier["prenom"] = textBoxPrenom.Text;
                DataRowAmodifier["age"] = textBoxAge.Text;
                DataRowAmodifier["email"] = textBoxEmail.Text;
            }

            
            // On modifie les état des textbox apres la modification effectuée
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxAge.Enabled = false;
            textBoxEmail.Enabled = false;
            labelPersonneModifier.Visible = true;
            buttonModifier.Enabled = false;
            textBoxIdRecherche.Select();

            
            MonDataAdapter.Update(MonDataSet.Tables[0]);

            // Affichage de la table dans le gridview
            dataGridViewModifier.DataSource = MonDataSet.Tables[0];
        }

        private void FormModifierPersonne_Load(object sender, EventArgs e)
        {
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
            dataGridViewModifier.DataSource = MonDataSetPersonne.Tables[0];
        }


    }
}
