namespace Contacts
{
    partial class frmContacts
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
            this.lblChoixPhoto = new System.Windows.Forms.Label();
            this.lstContact = new System.Windows.Forms.ListBox();
            this.grbAjout = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.grbContacts = new System.Windows.Forms.GroupBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.rbtParticulier = new System.Windows.Forms.RadioButton();
            this.rbtPro = new System.Windows.Forms.RadioButton();
            this.grbAjout.SuspendLayout();
            this.grbContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoixPhoto
            // 
            this.lblChoixPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixPhoto.Enabled = false;
            this.lblChoixPhoto.Location = new System.Drawing.Point(41, 229);
            this.lblChoixPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixPhoto.Name = "lblChoixPhoto";
            this.lblChoixPhoto.Size = new System.Drawing.Size(167, 39);
            this.lblChoixPhoto.TabIndex = 14;
            this.lblChoixPhoto.Text = "Cliquer pour sélectionner une photo";
            this.lblChoixPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoixPhoto.Visible = false;
            this.lblChoixPhoto.Click += new System.EventHandler(this.LblChoixPhoto_Click);
            // 
            // lstContact
            // 
            this.lstContact.FormattingEnabled = true;
            this.lstContact.HorizontalScrollbar = true;
            this.lstContact.ItemHeight = 16;
            this.lstContact.Location = new System.Drawing.Point(8, 23);
            this.lstContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstContact.Name = "lstContact";
            this.lstContact.Size = new System.Drawing.Size(423, 436);
            this.lstContact.TabIndex = 9;
            this.lstContact.SelectedIndexChanged += new System.EventHandler(this.LstContact_SelectedIndexChanged);
            // 
            // grbAjout
            // 
            this.grbAjout.Controls.Add(this.rbtPro);
            this.grbAjout.Controls.Add(this.rbtParticulier);
            this.grbAjout.Controls.Add(this.btnAnnuler);
            this.grbAjout.Controls.Add(this.btnAjouter);
            this.grbAjout.Controls.Add(this.txtTel);
            this.grbAjout.Controls.Add(this.label3);
            this.grbAjout.Controls.Add(this.txtPrenom);
            this.grbAjout.Controls.Add(this.lblPrenom);
            this.grbAjout.Controls.Add(this.txtNom);
            this.grbAjout.Controls.Add(this.label1);
            this.grbAjout.Location = new System.Drawing.Point(16, 326);
            this.grbAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbAjout.Name = "grbAjout";
            this.grbAjout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbAjout.Size = new System.Drawing.Size(227, 217);
            this.grbAjout.TabIndex = 8;
            this.grbAjout.TabStop = false;
            this.grbAjout.Text = "ajout contact";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Contacts.Properties.Resources.annuler;
            this.btnAnnuler.Location = new System.Drawing.Point(153, 151);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(60, 55);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Contacts.Properties.Resources.ajouter;
            this.btnAjouter.Location = new System.Drawing.Point(73, 151);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(60, 55);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(72, 119);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 22);
            this.txtTel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 87);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(140, 22);
            this.txtPrenom.TabIndex = 5;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(9, 91);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(56, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(72, 55);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 22);
            this.txtNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(16, 292);
            this.btnNouveauContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(225, 25);
            this.btnNouveauContact.TabIndex = 10;
            this.btnNouveauContact.Text = "nouveau contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // grbContacts
            // 
            this.grbContacts.Controls.Add(this.lstContact);
            this.grbContacts.Controls.Add(this.btnSuppr);
            this.grbContacts.Controls.Add(this.btnModif);
            this.grbContacts.Location = new System.Drawing.Point(251, 15);
            this.grbContacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbContacts.Name = "grbContacts";
            this.grbContacts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbContacts.Size = new System.Drawing.Size(444, 528);
            this.grbContacts.TabIndex = 15;
            this.grbContacts.TabStop = false;
            this.grbContacts.Text = "les contacts";
            // 
            // btnSuppr
            // 
            this.btnSuppr.Image = global::Contacts.Properties.Resources.supprimer;
            this.btnSuppr.Location = new System.Drawing.Point(372, 467);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(60, 55);
            this.btnSuppr.TabIndex = 10;
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Image = global::Contacts.Properties.Resources.modifier;
            this.btnModif.Location = new System.Drawing.Point(304, 467);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(60, 55);
            this.btnModif.TabIndex = 11;
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // imgPhoto
            // 
            this.imgPhoto.Enabled = false;
            this.imgPhoto.Image = global::Contacts.Properties.Resources.vide;
            this.imgPhoto.Location = new System.Drawing.Point(16, 38);
            this.imgPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(227, 246);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 13;
            this.imgPhoto.TabStop = false;
            this.imgPhoto.Click += new System.EventHandler(this.ImgPhoto_Click);
            // 
            // rbtParticulier
            // 
            this.rbtParticulier.AutoSize = true;
            this.rbtParticulier.Location = new System.Drawing.Point(12, 23);
            this.rbtParticulier.Name = "rbtParticulier";
            this.rbtParticulier.Size = new System.Drawing.Size(91, 21);
            this.rbtParticulier.TabIndex = 10;
            this.rbtParticulier.TabStop = true;
            this.rbtParticulier.Text = "particulier";
            this.rbtParticulier.UseVisualStyleBackColor = true;
            this.rbtParticulier.CheckedChanged += new System.EventHandler(this.rbtParticulier_CheckedChanged);
            // 
            // rbtPro
            // 
            this.rbtPro.AutoSize = true;
            this.rbtPro.Location = new System.Drawing.Point(109, 23);
            this.rbtPro.Name = "rbtPro";
            this.rbtPro.Size = new System.Drawing.Size(114, 21);
            this.rbtPro.TabIndex = 11;
            this.rbtPro.TabStop = true;
            this.rbtPro.Text = "professionnel";
            this.rbtPro.UseVisualStyleBackColor = true;
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 553);
            this.Controls.Add(this.grbContacts);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.lblChoixPhoto);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.grbAjout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmContacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.FrmContacts_Load);
            this.grbAjout.ResumeLayout(false);
            this.grbAjout.PerformLayout();
            this.grbContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChoixPhoto;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.ListBox lstContact;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.GroupBox grbAjout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.GroupBox grbContacts;
        private System.Windows.Forms.RadioButton rbtPro;
        private System.Windows.Forms.RadioButton rbtParticulier;
    }
}

