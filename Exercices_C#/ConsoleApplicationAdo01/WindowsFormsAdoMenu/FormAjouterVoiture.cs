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
    public partial class FormVoitureAjouter : Form
    {
        public FormVoitureAjouter()
        {
            InitializeComponent();
        }

        private void voitureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voitureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDPersonneDataSet);

        }

        private void FormVoitureAjouter_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDPersonneDataSet.Voiture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.voitureTableAdapter.Fill(this.bDDPersonneDataSet.Voiture);

        }
    }
}
