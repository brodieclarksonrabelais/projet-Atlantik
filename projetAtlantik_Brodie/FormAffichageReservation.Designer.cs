namespace projetAtlantik_Brodie
{
    partial class FormAffichageReservation
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
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.cmbNomReservation = new System.Windows.Forms.ComboBox();
            this.lvTableauReservation = new System.Windows.Forms.ListView();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.lblJunior = new System.Windows.Forms.Label();
            this.lblEnfant = new System.Windows.Forms.Label();
            this.lblVoitMoins5 = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblReglement = new System.Windows.Forms.Label();
            this.lblMontantAdulte = new System.Windows.Forms.Label();
            this.lblMontantJunior = new System.Windows.Forms.Label();
            this.lblMontantEnfant = new System.Windows.Forms.Label();
            this.lblMontantVoitMoins4 = new System.Windows.Forms.Label();
            this.lblMontantResultat = new System.Windows.Forms.Label();
            this.lblReglementResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomReservation
            // 
            this.lblNomReservation.AutoSize = true;
            this.lblNomReservation.Location = new System.Drawing.Point(25, 15);
            this.lblNomReservation.Name = "lblNomReservation";
            this.lblNomReservation.Size = new System.Drawing.Size(95, 16);
            this.lblNomReservation.TabIndex = 1;
            this.lblNomReservation.Text = "Nom, Prenom :";
            // 
            // cmbNomReservation
            // 
            this.cmbNomReservation.FormattingEnabled = true;
            this.cmbNomReservation.Location = new System.Drawing.Point(173, 12);
            this.cmbNomReservation.Name = "cmbNomReservation";
            this.cmbNomReservation.Size = new System.Drawing.Size(121, 24);
            this.cmbNomReservation.TabIndex = 3;
            this.cmbNomReservation.SelectedIndexChanged += new System.EventHandler(this.cmbNomReservation_SelectedIndexChanged);
            // 
            // lvTableauReservation
            // 
            this.lvTableauReservation.HideSelection = false;
            this.lvTableauReservation.Location = new System.Drawing.Point(28, 42);
            this.lvTableauReservation.Name = "lvTableauReservation";
            this.lvTableauReservation.Size = new System.Drawing.Size(683, 377);
            this.lvTableauReservation.TabIndex = 4;
            this.lvTableauReservation.UseCompatibleStateImageBehavior = false;
            this.lvTableauReservation.SelectedIndexChanged += new System.EventHandler(this.lvTableauReservation_SelectedIndexChanged);
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(767, 52);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(51, 16);
            this.lblAdulte.TabIndex = 5;
            this.lblAdulte.Text = "Adulte :";
            this.lblAdulte.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJunior
            // 
            this.lblJunior.AutoSize = true;
            this.lblJunior.Location = new System.Drawing.Point(767, 109);
            this.lblJunior.Name = "lblJunior";
            this.lblJunior.Size = new System.Drawing.Size(112, 16);
            this.lblJunior.TabIndex = 6;
            this.lblJunior.Text = "Junior 8 à 18 ans :";
            // 
            // lblEnfant
            // 
            this.lblEnfant.AutoSize = true;
            this.lblEnfant.Location = new System.Drawing.Point(767, 169);
            this.lblEnfant.Name = "lblEnfant";
            this.lblEnfant.Size = new System.Drawing.Size(106, 16);
            this.lblEnfant.TabIndex = 7;
            this.lblEnfant.Text = "Enfant 0 à 7 ans :";
            // 
            // lblVoitMoins5
            // 
            this.lblVoitMoins5.AutoSize = true;
            this.lblVoitMoins5.Location = new System.Drawing.Point(767, 224);
            this.lblVoitMoins5.Name = "lblVoitMoins5";
            this.lblVoitMoins5.Size = new System.Drawing.Size(121, 16);
            this.lblVoitMoins5.TabIndex = 8;
            this.lblVoitMoins5.Text = "Voiture long.inf.5m :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(767, 283);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(88, 16);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant total :";
            this.lblMontant.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblReglement
            // 
            this.lblReglement.AutoSize = true;
            this.lblReglement.Location = new System.Drawing.Point(767, 339);
            this.lblReglement.Name = "lblReglement";
            this.lblReglement.Size = new System.Drawing.Size(130, 16);
            this.lblReglement.TabIndex = 10;
            this.lblReglement.Text = "Mode de reglement :";
            // 
            // lblMontantAdulte
            // 
            this.lblMontantAdulte.AutoSize = true;
            this.lblMontantAdulte.Location = new System.Drawing.Point(954, 52);
            this.lblMontantAdulte.Name = "lblMontantAdulte";
            this.lblMontantAdulte.Size = new System.Drawing.Size(0, 16);
            this.lblMontantAdulte.TabIndex = 11;
            // 
            // lblMontantJunior
            // 
            this.lblMontantJunior.AutoSize = true;
            this.lblMontantJunior.Location = new System.Drawing.Point(954, 109);
            this.lblMontantJunior.Name = "lblMontantJunior";
            this.lblMontantJunior.Size = new System.Drawing.Size(0, 16);
            this.lblMontantJunior.TabIndex = 12;
            // 
            // lblMontantEnfant
            // 
            this.lblMontantEnfant.AutoSize = true;
            this.lblMontantEnfant.Location = new System.Drawing.Point(954, 169);
            this.lblMontantEnfant.Name = "lblMontantEnfant";
            this.lblMontantEnfant.Size = new System.Drawing.Size(0, 16);
            this.lblMontantEnfant.TabIndex = 13;
            // 
            // lblMontantVoitMoins4
            // 
            this.lblMontantVoitMoins4.AutoSize = true;
            this.lblMontantVoitMoins4.Location = new System.Drawing.Point(954, 224);
            this.lblMontantVoitMoins4.Name = "lblMontantVoitMoins4";
            this.lblMontantVoitMoins4.Size = new System.Drawing.Size(0, 16);
            this.lblMontantVoitMoins4.TabIndex = 14;
            // 
            // lblMontantResultat
            // 
            this.lblMontantResultat.AutoSize = true;
            this.lblMontantResultat.Location = new System.Drawing.Point(954, 283);
            this.lblMontantResultat.Name = "lblMontantResultat";
            this.lblMontantResultat.Size = new System.Drawing.Size(0, 16);
            this.lblMontantResultat.TabIndex = 15;
            // 
            // lblReglementResultat
            // 
            this.lblReglementResultat.AutoSize = true;
            this.lblReglementResultat.Location = new System.Drawing.Point(954, 339);
            this.lblReglementResultat.Name = "lblReglementResultat";
            this.lblReglementResultat.Size = new System.Drawing.Size(0, 16);
            this.lblReglementResultat.TabIndex = 16;
            // 
            // FormAffichageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.lblReglementResultat);
            this.Controls.Add(this.lblMontantResultat);
            this.Controls.Add(this.lblMontantVoitMoins4);
            this.Controls.Add(this.lblMontantEnfant);
            this.Controls.Add(this.lblMontantJunior);
            this.Controls.Add(this.lblMontantAdulte);
            this.Controls.Add(this.lblReglement);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblVoitMoins5);
            this.Controls.Add(this.lblEnfant);
            this.Controls.Add(this.lblJunior);
            this.Controls.Add(this.lblAdulte);
            this.Controls.Add(this.lvTableauReservation);
            this.Controls.Add(this.cmbNomReservation);
            this.Controls.Add(this.lblNomReservation);
            this.Name = "FormAffichageReservation";
            this.Text = "FormAffichageReservation";
            this.Load += new System.EventHandler(this.FormAffichageReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomReservation;
        private System.Windows.Forms.ComboBox cmbNomReservation;
        private System.Windows.Forms.ListView lvTableauReservation;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.Label lblJunior;
        private System.Windows.Forms.Label lblEnfant;
        private System.Windows.Forms.Label lblVoitMoins5;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblReglement;
        private System.Windows.Forms.Label lblMontantAdulte;
        private System.Windows.Forms.Label lblMontantJunior;
        private System.Windows.Forms.Label lblMontantEnfant;
        private System.Windows.Forms.Label lblMontantVoitMoins4;
        private System.Windows.Forms.Label lblMontantResultat;
        private System.Windows.Forms.Label lblReglementResultat;
    }
}