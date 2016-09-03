namespace WindowsFormsAdoMenu
{
    partial class FormModifierPersonne
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
            this.labelPersonneModifier = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxIdRecherche = new System.Windows.Forms.TextBox();
            this.labelNomRecherche = new System.Windows.Forms.Label();
            this.labelErreurRechercheId = new System.Windows.Forms.Label();
            this.buttonRechercherId = new System.Windows.Forms.Button();
            this.dataGridViewModifier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersonneModifier
            // 
            this.labelPersonneModifier.AutoSize = true;
            this.labelPersonneModifier.Location = new System.Drawing.Point(222, 404);
            this.labelPersonneModifier.Name = "labelPersonneModifier";
            this.labelPersonneModifier.Size = new System.Drawing.Size(155, 13);
            this.labelPersonneModifier.TabIndex = 21;
            this.labelPersonneModifier.Text = "Personne Modifié avec Succes";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(318, 420);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 20;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(188, 420);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 19;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(188, 377);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(205, 20);
            this.textBoxEmail.TabIndex = 18;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(188, 350);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(205, 20);
            this.textBoxAge.TabIndex = 17;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(188, 321);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrenom.TabIndex = 16;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(188, 294);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(205, 20);
            this.textBoxNom.TabIndex = 15;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(105, 380);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(79, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Adresse Email :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(150, 357);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 13;
            this.labelAge.Text = "Age :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(133, 328);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 12;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(147, 301);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 11;
            this.labelNom.Text = "Nom :";
            // 
            // textBoxIdRecherche
            // 
            this.textBoxIdRecherche.Location = new System.Drawing.Point(188, 239);
            this.textBoxIdRecherche.Name = "textBoxIdRecherche";
            this.textBoxIdRecherche.Size = new System.Drawing.Size(205, 20);
            this.textBoxIdRecherche.TabIndex = 23;
            this.textBoxIdRecherche.TextChanged += new System.EventHandler(this.textBoxIdRecherche_TextChanged);
            // 
            // labelNomRecherche
            // 
            this.labelNomRecherche.AutoSize = true;
            this.labelNomRecherche.Location = new System.Drawing.Point(107, 219);
            this.labelNomRecherche.Name = "labelNomRecherche";
            this.labelNomRecherche.Size = new System.Drawing.Size(182, 13);
            this.labelNomRecherche.TabIndex = 22;
            this.labelNomRecherche.Text = "Identifiant de la Personne à Modifier :";
            // 
            // labelErreurRechercheId
            // 
            this.labelErreurRechercheId.AutoSize = true;
            this.labelErreurRechercheId.Location = new System.Drawing.Point(107, 270);
            this.labelErreurRechercheId.Name = "labelErreurRechercheId";
            this.labelErreurRechercheId.Size = new System.Drawing.Size(187, 13);
            this.labelErreurRechercheId.TabIndex = 25;
            this.labelErreurRechercheId.Text = "Aucune personne trouvée avec cet Id";
            // 
            // buttonRechercherId
            // 
            this.buttonRechercherId.Location = new System.Drawing.Point(314, 265);
            this.buttonRechercherId.Name = "buttonRechercherId";
            this.buttonRechercherId.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercherId.TabIndex = 24;
            this.buttonRechercherId.Text = "Rechercher";
            this.buttonRechercherId.UseVisualStyleBackColor = true;
            this.buttonRechercherId.Click += new System.EventHandler(this.buttonRechercherId_Click);
            // 
            // dataGridViewModifier
            // 
            this.dataGridViewModifier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewModifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifier.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewModifier.Name = "dataGridViewModifier";
            this.dataGridViewModifier.Size = new System.Drawing.Size(504, 203);
            this.dataGridViewModifier.TabIndex = 42;
            // 
            // FormModifierPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 460);
            this.Controls.Add(this.dataGridViewModifier);
            this.Controls.Add(this.labelErreurRechercheId);
            this.Controls.Add(this.buttonRechercherId);
            this.Controls.Add(this.textBoxIdRecherche);
            this.Controls.Add(this.labelNomRecherche);
            this.Controls.Add(this.labelPersonneModifier);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormModifierPersonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une Personnel";
            this.Load += new System.EventHandler(this.FormModifierPersonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonneModifier;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxIdRecherche;
        private System.Windows.Forms.Label labelNomRecherche;
        private System.Windows.Forms.Label labelErreurRechercheId;
        private System.Windows.Forms.Button buttonRechercherId;
        private System.Windows.Forms.DataGridView dataGridViewModifier;
    }
}