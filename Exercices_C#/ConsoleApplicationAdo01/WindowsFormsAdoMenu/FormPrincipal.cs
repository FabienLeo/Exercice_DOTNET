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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
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
            dataGridViewPrincipal.DataSource = MonDataSetPersonne.Tables[0];
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterPersonne formulaireListerPersonne = new FormAjouterPersonne();
            formulaireListerPersonne.ShowDialog();


        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifierPersonne formulaireModifierPersonne = new FormModifierPersonne();
            formulaireModifierPersonne.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuppPersonne formulaireSupprimerPersonne = new FormSuppPersonne();
            formulaireSupprimerPersonne.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVoitureAjouter FormulaireAjouterVoiture = new FormVoitureAjouter();
            FormulaireAjouterVoiture.ShowDialog();
        }

        private void listerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVoitureLister FormulaireListerVoiture = new FormVoitureLister();
            FormulaireListerVoiture.ShowDialog();
        }

    }
}
