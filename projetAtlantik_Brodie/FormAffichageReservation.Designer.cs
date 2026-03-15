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
            this.gbxReservation = new System.Windows.Forms.GroupBox();
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
            this.lvTableauReservation.Location = new System.Drawing.Point(28, 52);
            this.lvTableauReservation.Name = "lvTableauReservation";
            this.lvTableauReservation.Size = new System.Drawing.Size(683, 377);
            this.lvTableauReservation.TabIndex = 4;
            this.lvTableauReservation.UseCompatibleStateImageBehavior = false;
            this.lvTableauReservation.SelectedIndexChanged += new System.EventHandler(this.lvTableauReservation_SelectedIndexChanged);
            // 
            // gbxReservation
            // 
            this.gbxReservation.Location = new System.Drawing.Point(738, 12);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Size = new System.Drawing.Size(374, 417);
            this.gbxReservation.TabIndex = 5;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            // 
            // FormAffichageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.gbxReservation);
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
        private System.Windows.Forms.GroupBox gbxReservation;
    }
}