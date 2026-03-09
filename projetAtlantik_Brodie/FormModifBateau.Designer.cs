namespace projetAtlantik_Brodie
{
    partial class FormModifBateau
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
            this.lblNomBateauListe = new System.Windows.Forms.Label();
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.gbxCapaciteMaxModif = new System.Windows.Forms.GroupBox();
            this.btnModifierBateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateauListe
            // 
            this.lblNomBateauListe.AutoSize = true;
            this.lblNomBateauListe.Location = new System.Drawing.Point(28, 63);
            this.lblNomBateauListe.Name = "lblNomBateauListe";
            this.lblNomBateauListe.Size = new System.Drawing.Size(86, 13);
            this.lblNomBateauListe.TabIndex = 0;
            this.lblNomBateauListe.Text = "Nom du bateau :";
            // 
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(120, 63);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbNomBateau.TabIndex = 1;
            this.cmbNomBateau.SelectedIndexChanged += new System.EventHandler(this.cmbNomBateau_SelectedIndexChanged);
            // 
            // gbxCapaciteMaxModif
            // 
            this.gbxCapaciteMaxModif.Location = new System.Drawing.Point(394, 60);
            this.gbxCapaciteMaxModif.Name = "gbxCapaciteMaxModif";
            this.gbxCapaciteMaxModif.Size = new System.Drawing.Size(294, 290);
            this.gbxCapaciteMaxModif.TabIndex = 2;
            this.gbxCapaciteMaxModif.TabStop = false;
            this.gbxCapaciteMaxModif.Text = "groupBox1";
            // 
            // btnModifierBateau
            // 
            this.btnModifierBateau.Location = new System.Drawing.Point(357, 384);
            this.btnModifierBateau.Name = "btnModifierBateau";
            this.btnModifierBateau.Size = new System.Drawing.Size(75, 23);
            this.btnModifierBateau.TabIndex = 3;
            this.btnModifierBateau.Text = "Modifier";
            this.btnModifierBateau.UseVisualStyleBackColor = true;
            this.btnModifierBateau.Click += new System.EventHandler(this.btnModifierBateau_Click);
            // 
            // FormModifBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifierBateau);
            this.Controls.Add(this.gbxCapaciteMaxModif);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.lblNomBateauListe);
            this.Name = "FormModifBateau";
            this.Text = "FormModifBateau";
            this.Load += new System.EventHandler(this.FormModifBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateauListe;
        private System.Windows.Forms.ComboBox cmbNomBateau;
        private System.Windows.Forms.GroupBox gbxCapaciteMaxModif;
        private System.Windows.Forms.Button btnModifierBateau;
    }
}