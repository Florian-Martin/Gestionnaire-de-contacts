namespace Gestionnaire
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAjout = new System.Windows.Forms.GroupBox();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.rdbParticulier = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtRechTel = new System.Windows.Forms.TextBox();
            this.lblRechTel = new System.Windows.Forms.Label();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.grpAjout.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAjout
            // 
            this.grpAjout.Controls.Add(this.rdbPro);
            this.grpAjout.Controls.Add(this.rdbParticulier);
            this.grpAjout.Controls.Add(this.btnCancel);
            this.grpAjout.Controls.Add(this.btnAjout);
            this.grpAjout.Controls.Add(this.txtTel);
            this.grpAjout.Controls.Add(this.txtPrenom);
            this.grpAjout.Controls.Add(this.txtNom);
            this.grpAjout.Controls.Add(this.lblTel);
            this.grpAjout.Controls.Add(this.lblPrenom);
            this.grpAjout.Controls.Add(this.lblNom);
            this.grpAjout.Location = new System.Drawing.Point(63, 182);
            this.grpAjout.Name = "grpAjout";
            this.grpAjout.Size = new System.Drawing.Size(282, 172);
            this.grpAjout.TabIndex = 1;
            this.grpAjout.TabStop = false;
            this.grpAjout.Text = "Ajout contact";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Location = new System.Drawing.Point(151, 28);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(88, 17);
            this.rdbPro.TabIndex = 9;
            this.rdbPro.Text = "Professionnel";
            this.rdbPro.UseVisualStyleBackColor = true;
            this.rdbPro.CheckedChanged += new System.EventHandler(this.rdbPro_CheckedChanged);
            // 
            // rdbParticulier
            // 
            this.rdbParticulier.AutoSize = true;
            this.rdbParticulier.Checked = true;
            this.rdbParticulier.Location = new System.Drawing.Point(49, 28);
            this.rdbParticulier.Name = "rdbParticulier";
            this.rdbParticulier.Size = new System.Drawing.Size(71, 17);
            this.rdbParticulier.TabIndex = 8;
            this.rdbParticulier.TabStop = true;
            this.rdbParticulier.Text = "Particulier";
            this.rdbParticulier.UseVisualStyleBackColor = true;
            this.rdbParticulier.CheckedChanged += new System.EventHandler(this.rdbParticulier_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(191, 61);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 43);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(69, 133);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(69, 97);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(69, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(6, 133);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 97);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 61);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.btnReset);
            this.grpRecherche.Controls.Add(this.txtRechTel);
            this.grpRecherche.Controls.Add(this.lblRechTel);
            this.grpRecherche.Location = new System.Drawing.Point(63, 369);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(282, 66);
            this.grpRecherche.TabIndex = 2;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "Recherche";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(191, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtRechTel
            // 
            this.txtRechTel.Location = new System.Drawing.Point(69, 24);
            this.txtRechTel.Name = "txtRechTel";
            this.txtRechTel.Size = new System.Drawing.Size(100, 20);
            this.txtRechTel.TabIndex = 1;
            this.txtRechTel.TextChanged += new System.EventHandler(this.txtRechTel_TextChanged);
            // 
            // lblRechTel
            // 
            this.lblRechTel.AutoSize = true;
            this.lblRechTel.Location = new System.Drawing.Point(6, 27);
            this.lblRechTel.Name = "lblRechTel";
            this.lblRechTel.Size = new System.Drawing.Size(28, 13);
            this.lblRechTel.TabIndex = 0;
            this.lblRechTel.Text = "Tel :";
            // 
            // lstContacts
            // 
            this.lstContacts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(364, 12);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(223, 394);
            this.lstContacts.Sorted = true;
            this.lstContacts.TabIndex = 3;
            this.lstContacts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContacts_DrawItem);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(254, 45);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 43);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(254, 106);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 43);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(63, 12);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(157, 164);
            this.pctPhoto.TabIndex = 0;
            this.pctPhoto.TabStop = false;
            this.pctPhoto.Click += new System.EventHandler(this.pctPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 447);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpAjout);
            this.Controls.Add(this.pctPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAjout.ResumeLayout(false);
            this.grpAjout.PerformLayout();
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.GroupBox grpAjout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.RadioButton rdbParticulier;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtRechTel;
        private System.Windows.Forms.Label lblRechTel;
    }
}

