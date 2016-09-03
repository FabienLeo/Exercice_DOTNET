namespace WindowsFormsAdoMenu
{
    partial class FormVoitureAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoitureAjouter));
            System.Windows.Forms.Label couleurLabel;
            System.Windows.Forms.Label portesLabel;
            System.Windows.Forms.Label personneIdLabel;
            this.bDDPersonneDataSet = new WindowsFormsAdoMenu.BDDPersonneDataSet();
            this.voitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voitureTableAdapter = new WindowsFormsAdoMenu.BDDPersonneDataSetTableAdapters.VoitureTableAdapter();
            this.tableAdapterManager = new WindowsFormsAdoMenu.BDDPersonneDataSetTableAdapters.TableAdapterManager();
            this.voitureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.voitureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voitureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurTextBox = new System.Windows.Forms.TextBox();
            this.portesTextBox = new System.Windows.Forms.TextBox();
            this.personneIdTextBox = new System.Windows.Forms.TextBox();
            couleurLabel = new System.Windows.Forms.Label();
            portesLabel = new System.Windows.Forms.Label();
            personneIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDDPersonneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingNavigator)).BeginInit();
            this.voitureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDPersonneDataSet
            // 
            this.bDDPersonneDataSet.DataSetName = "BDDPersonneDataSet";
            this.bDDPersonneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voitureBindingSource
            // 
            this.voitureBindingSource.DataMember = "Voiture";
            this.voitureBindingSource.DataSource = this.bDDPersonneDataSet;
            // 
            // voitureTableAdapter
            // 
            this.voitureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresseTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FormationTableAdapter = null;
            this.tableAdapterManager.PersonneFormationTableAdapter = null;
            this.tableAdapterManager.PersonneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAdoMenu.BDDPersonneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoitureTableAdapter = this.voitureTableAdapter;
            // 
            // voitureBindingNavigator
            // 
            this.voitureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.voitureBindingNavigator.BindingSource = this.voitureBindingSource;
            this.voitureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.voitureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.voitureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.voitureBindingNavigatorSaveItem});
            this.voitureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.voitureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.voitureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.voitureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.voitureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.voitureBindingNavigator.Name = "voitureBindingNavigator";
            this.voitureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.voitureBindingNavigator.Size = new System.Drawing.Size(311, 25);
            this.voitureBindingNavigator.TabIndex = 0;
            this.voitureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // voitureBindingNavigatorSaveItem
            // 
            this.voitureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.voitureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("voitureBindingNavigatorSaveItem.Image")));
            this.voitureBindingNavigatorSaveItem.Name = "voitureBindingNavigatorSaveItem";
            this.voitureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.voitureBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.voitureBindingNavigatorSaveItem.Click += new System.EventHandler(this.voitureBindingNavigatorSaveItem_Click);
            // 
            // voitureDataGridView
            // 
            this.voitureDataGridView.AutoGenerateColumns = false;
            this.voitureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.voitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.voitureDataGridView.DataSource = this.voitureBindingSource;
            this.voitureDataGridView.Location = new System.Drawing.Point(7, 134);
            this.voitureDataGridView.Name = "voitureDataGridView";
            this.voitureDataGridView.Size = new System.Drawing.Size(297, 215);
            this.voitureDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "couleur";
            this.dataGridViewTextBoxColumn2.HeaderText = "couleur";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 67;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "portes";
            this.dataGridViewTextBoxColumn3.HeaderText = "portes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PersonneId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PersonneId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 86;
            // 
            // couleurLabel
            // 
            couleurLabel.AutoSize = true;
            couleurLabel.Location = new System.Drawing.Point(65, 33);
            couleurLabel.Name = "couleurLabel";
            couleurLabel.Size = new System.Drawing.Size(45, 13);
            couleurLabel.TabIndex = 4;
            couleurLabel.Text = "couleur:";
            // 
            // couleurTextBox
            // 
            this.couleurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voitureBindingSource, "couleur", true));
            this.couleurTextBox.Location = new System.Drawing.Point(138, 30);
            this.couleurTextBox.Name = "couleurTextBox";
            this.couleurTextBox.Size = new System.Drawing.Size(100, 20);
            this.couleurTextBox.TabIndex = 5;
            // 
            // portesLabel
            // 
            portesLabel.AutoSize = true;
            portesLabel.Location = new System.Drawing.Point(65, 59);
            portesLabel.Name = "portesLabel";
            portesLabel.Size = new System.Drawing.Size(39, 13);
            portesLabel.TabIndex = 6;
            portesLabel.Text = "portes:";
            // 
            // portesTextBox
            // 
            this.portesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voitureBindingSource, "portes", true));
            this.portesTextBox.Location = new System.Drawing.Point(138, 56);
            this.portesTextBox.Name = "portesTextBox";
            this.portesTextBox.Size = new System.Drawing.Size(100, 20);
            this.portesTextBox.TabIndex = 7;
            // 
            // personneIdLabel
            // 
            personneIdLabel.AutoSize = true;
            personneIdLabel.Location = new System.Drawing.Point(65, 85);
            personneIdLabel.Name = "personneIdLabel";
            personneIdLabel.Size = new System.Drawing.Size(67, 13);
            personneIdLabel.TabIndex = 8;
            personneIdLabel.Text = "Personne Id:";
            // 
            // personneIdTextBox
            // 
            this.personneIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voitureBindingSource, "PersonneId", true));
            this.personneIdTextBox.Location = new System.Drawing.Point(138, 82);
            this.personneIdTextBox.Name = "personneIdTextBox";
            this.personneIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.personneIdTextBox.TabIndex = 9;
            // 
            // FormVoitureAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 353);
            this.Controls.Add(couleurLabel);
            this.Controls.Add(this.couleurTextBox);
            this.Controls.Add(portesLabel);
            this.Controls.Add(this.portesTextBox);
            this.Controls.Add(personneIdLabel);
            this.Controls.Add(this.personneIdTextBox);
            this.Controls.Add(this.voitureDataGridView);
            this.Controls.Add(this.voitureBindingNavigator);
            this.Name = "FormVoitureAjouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une Voiture";
            this.Load += new System.EventHandler(this.FormVoitureAjouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDPersonneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingNavigator)).EndInit();
            this.voitureBindingNavigator.ResumeLayout(false);
            this.voitureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDPersonneDataSet bDDPersonneDataSet;
        private System.Windows.Forms.BindingSource voitureBindingSource;
        private BDDPersonneDataSetTableAdapters.VoitureTableAdapter voitureTableAdapter;
        private BDDPersonneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator voitureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton voitureBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView voitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox couleurTextBox;
        private System.Windows.Forms.TextBox portesTextBox;
        private System.Windows.Forms.TextBox personneIdTextBox;
    }
}