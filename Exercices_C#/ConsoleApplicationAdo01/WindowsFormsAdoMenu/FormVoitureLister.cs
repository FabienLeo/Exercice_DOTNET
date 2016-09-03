using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdoMenu
{
    public partial class FormVoitureLister : Form
    {
        public FormVoitureLister()
        {
            InitializeComponent();
        }

        private void voitureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voitureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDPersonneDataSet);

        }

        private void FormVoitureLister_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDPersonneDataSet.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.personneTableAdapter.Fill(this.bDDPersonneDataSet.Personne);
            // TODO: cette ligne de code charge les données dans la table 'bDDPersonneDataSet.Voiture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.voitureTableAdapter.Fill(this.bDDPersonneDataSet.Voiture);

        }

        private void comboBoxPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Déclaration du data view que l'on affectera parès au datagridview de notre form
            DataView MonDataViewVoiturePersonne = new DataView(bDDPersonneDataSet.Tables["Voiture"],"PersonneId="+comboBoxPersonne.SelectedValue,"Couleur asc",DataViewRowState.CurrentRows);

            // Affectationk de notre dataview à notre datdagridview
            voitureDataGridView.DataSource = MonDataViewVoiturePersonne;

        }
    }
}
