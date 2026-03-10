namespace projetAtlantik_Brodie
{
    partial class FormAjoutTraversee
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
            this.lblSecteursTraversee = new System.Windows.Forms.Label();
            this.lblBateauTraversee = new System.Windows.Forms.Label();
            this.lblLiaisonTraversee = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateArivee = new System.Windows.Forms.Label();
            this.lbxSecteursTraversee = new System.Windows.Forms.ListBox();
            this.cmbBateauTraversee = new System.Windows.Forms.ComboBox();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.btnAjoutTraversee = new System.Windows.Forms.Button();
            this.cmbLiaisonTraversee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSecteursTraversee
            // 
            this.lblSecteursTraversee.AutoSize = true;
            this.lblSecteursTraversee.Location = new System.Drawing.Point(31, 35);
            this.lblSecteursTraversee.Name = "lblSecteursTraversee";
            this.lblSecteursTraversee.Size = new System.Drawing.Size(55, 13);
            this.lblSecteursTraversee.TabIndex = 0;
            this.lblSecteursTraversee.Text = "Secteurs :";
            // 
            // lblBateauTraversee
            // 
            this.lblBateauTraversee.AutoSize = true;
            this.lblBateauTraversee.Location = new System.Drawing.Point(280, 35);
            this.lblBateauTraversee.Name = "lblBateauTraversee";
            this.lblBateauTraversee.Size = new System.Drawing.Size(86, 13);
            this.lblBateauTraversee.TabIndex = 1;
            this.lblBateauTraversee.Text = "Nom du bateau :";
            // 
            // lblLiaisonTraversee
            // 
            this.lblLiaisonTraversee.AutoSize = true;
            this.lblLiaisonTraversee.Location = new System.Drawing.Point(34, 313);
            this.lblLiaisonTraversee.Name = "lblLiaisonTraversee";
            this.lblLiaisonTraversee.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonTraversee.TabIndex = 2;
            this.lblLiaisonTraversee.Text = "Liaison :";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(280, 193);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(126, 13);
            this.lblDateDepart.TabIndex = 3;
            this.lblDateDepart.Text = "Date et heure de départ :";
            // 
            // lblDateArivee
            // 
            this.lblDateArivee.AutoSize = true;
            this.lblDateArivee.Location = new System.Drawing.Point(280, 258);
            this.lblDateArivee.Name = "lblDateArivee";
            this.lblDateArivee.Size = new System.Drawing.Size(121, 13);
            this.lblDateArivee.TabIndex = 4;
            this.lblDateArivee.Text = "Date et heure d\'arrivée :";
            // 
            // lbxSecteursTraversee
            // 
            this.lbxSecteursTraversee.FormattingEnabled = true;
            this.lbxSecteursTraversee.Location = new System.Drawing.Point(34, 67);
            this.lbxSecteursTraversee.Name = "lbxSecteursTraversee";
            this.lbxSecteursTraversee.Size = new System.Drawing.Size(184, 225);
            this.lbxSecteursTraversee.TabIndex = 5;
            this.lbxSecteursTraversee.SelectedIndexChanged += new System.EventHandler(this.lbxSecteursTraversee_SelectedIndexChanged);
            // 
            // cmbBateauTraversee
            // 
            this.cmbBateauTraversee.FormattingEnabled = true;
            this.cmbBateauTraversee.Location = new System.Drawing.Point(420, 35);
            this.cmbBateauTraversee.Name = "cmbBateauTraversee";
            this.cmbBateauTraversee.Size = new System.Drawing.Size(121, 21);
            this.cmbBateauTraversee.TabIndex = 6;
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(447, 193);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(200, 20);
            this.dateDepart.TabIndex = 7;
            this.dateDepart.ValueChanged += new System.EventHandler(this.dateDepart_ValueChanged);
            // 
            // dateArrivee
            // 
            this.dateArrivee.Location = new System.Drawing.Point(447, 252);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(200, 20);
            this.dateArrivee.TabIndex = 8;
            // 
            // btnAjoutTraversee
            // 
            this.btnAjoutTraversee.Location = new System.Drawing.Point(353, 388);
            this.btnAjoutTraversee.Name = "btnAjoutTraversee";
            this.btnAjoutTraversee.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutTraversee.TabIndex = 9;
            this.btnAjoutTraversee.Text = "Ajouter";
            this.btnAjoutTraversee.UseVisualStyleBackColor = true;
            this.btnAjoutTraversee.Click += new System.EventHandler(this.btnAjoutTraversee_Click);
            // 
            // cmbLiaisonTraversee
            // 
            this.cmbLiaisonTraversee.FormattingEnabled = true;
            this.cmbLiaisonTraversee.Location = new System.Drawing.Point(34, 361);
            this.cmbLiaisonTraversee.Name = "cmbLiaisonTraversee";
            this.cmbLiaisonTraversee.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonTraversee.TabIndex = 10;
            // 
            // FormAjoutTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLiaisonTraversee);
            this.Controls.Add(this.btnAjoutTraversee);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.cmbBateauTraversee);
            this.Controls.Add(this.lbxSecteursTraversee);
            this.Controls.Add(this.lblDateArivee);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblLiaisonTraversee);
            this.Controls.Add(this.lblBateauTraversee);
            this.Controls.Add(this.lblSecteursTraversee);
            this.Name = "FormAjoutTraversee";
            this.Text = "FormAjoutTraversee";
            this.Load += new System.EventHandler(this.FormAjoutTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteursTraversee;
        private System.Windows.Forms.Label lblBateauTraversee;
        private System.Windows.Forms.Label lblLiaisonTraversee;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateArivee;
        private System.Windows.Forms.ListBox lbxSecteursTraversee;
        private System.Windows.Forms.ComboBox cmbBateauTraversee;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Button btnAjoutTraversee;
        private System.Windows.Forms.ComboBox cmbLiaisonTraversee;
    }
}