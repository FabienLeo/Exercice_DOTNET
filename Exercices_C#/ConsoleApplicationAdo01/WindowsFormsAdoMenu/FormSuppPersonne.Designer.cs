namespace WindowsFormsAdoMenu
{
    partial class FormSuppPersonne
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
            this.labelErreurRechercheId = new System.Windows.Forms.Label();
            this.buttonRechercherId = new System.Windows.Forms.Button();
            this.textBoxIdRecherche = new System.Windows.Forms.TextBox();
            this.labelNomRecherche = new System.Windows.Forms.Label();
            this.labelPersonneSupprime = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridViewSupprimer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErreurRechercheId
            // 
            this.labelErreurRechercheId.AutoSize = true;
            this.labelErreurRechercheId.Location = new System.Drawing.Point(105, 279);
            this.labelErreurRechercheId.Name = "labelErreurRechercheId";
            this.labelErreurRechercheId.Size = new System.Drawing.Size(187, 13);
            this.labelErreurRechercheId.TabIndex = 40;
            this.labelErreurRechercheId.Text = "Aucune personne trouvée avec cet Id";
            // 
            // buttonRechercherId
            // 
            this.buttonRechercherId.Location = new System.Drawing.Point(312, 274);
            this.buttonRechercherId.Name = "buttonRechercherId";
            this.buttonRechercherId.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercherId.TabIndex = 39;
            this.buttonRechercherId.Text = "Rechercher";
            this.buttonRechercherId.UseVisualStyleBackColor = true;
            this.buttonRechercherId.Click += new System.EventHandler(this.buttonRechercherId_Click);
            // 
            // textBoxIdRecherche
            // 
            this.textBoxIdRecherche.Location = new System.Drawing.Point(186, 248);
            this.textBoxIdRecherche.Name = "textBoxIdRecherche";
            this.textBoxIdRecherche.Size = new System.Drawing.Size(205, 20);
            this.textBoxIdRecherche.TabIndex = 38;
            this.textBoxIdRecherche.TextChanged += new System.EventHandler(this.textBoxIdRecherche_TextChanged);
            // 
            // labelNomRecherche
            // 
            this.labelNomRecherche.AutoSize = true;
            this.labelNomRecherche.Location = new System.Drawing.Point(105, 228);
            this.labelNomRecherche.Name = "labelNomRecherche";
            this.labelNomRecherche.Size = new System.Drawing.Size(192, 13);
            this.labelNomRecherche.TabIndex = 37;
            this.labelNomRecherche.Text = "Identifiant de la Personne à Supprimer :";
            // 
            // labelPersonneSupprime
            // 
            this.labelPersonneSupprime.AutoSize = true;
            this.labelPersonneSupprime.Location = new System.Drawing.Point(220, 413);
            this.labelPersonneSupprime.Name = "labelPersonneSupprime";
            this.labelPersonneSupprime.Size = new System.Drawing.Size(165, 13);
            this.labelPersonneSupprime.TabIndex = 36;
            this.labelPersonneSupprime.Text = "Personne Supprime avec Succes";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(316, 429);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 35;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(186, 429);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 34;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(186, 386);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(205, 20);
            this.textBoxEmail.TabIndex = 33;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(186, 359);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(205, 20);
            this.textBoxAge.TabIndex = 32;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(186, 330);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrenom.TabIndex = 31;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(186, 303);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(205, 20);
            this.textBoxNom.TabIndex = 30;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(103, 389);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(79, 13);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "Adresse Email :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(148, 366);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 28;
            this.labelAge.Text = "Age :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(131, 337);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 27;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(145, 310);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 26;
            this.labelNom.Text = "Nom :";
            // 
            // dataGridViewSupprimer
            // 
            this.dataGridViewSupprimer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSupprimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupprimer.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSupprimer.Name = "dataGridViewSupprimer";
            this.dataGridViewSupprimer.Size = new System.Drawing.Size(504, 203);
            this.dataGridViewSupprimer.TabIndex = 41;
            // 
            // FormSuppPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 468);
            this.Controls.Add(this.dataGridViewSupprimer);
            this.Controls.Add(this.labelErreurRechercheId);
            this.Controls.Add(this.buttonRechercherId);
            this.Controls.Add(this.textBoxIdRecherche);
            this.Controls.Add(this.labelNomRecherche);
            this.Controls.Add(this.labelPersonneSupprime);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormSuppPersonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer une Personne";
            this.Load += new System.EventHandler(this.FormSuppPersonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurRechercheId;
        private System.Windows.Forms.Button buttonRechercherId;
        private System.Windows.Forms.TextBox textBoxIdRecherche;
        private System.Windows.Forms.Label labelNomRecherche;
        private System.Windows.Forms.Label labelPersonneSupprime;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridViewSupprimer;
    }
}