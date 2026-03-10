namespace projetAtlantik_Brodie
{
    partial class FormAffichageTraversee
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
            this.lbxSecteursTraversee = new System.Windows.Forms.ListBox();
            this.lblLiaisonTraversee = new System.Windows.Forms.Label();
            this.cmbLiaisonTraversee = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDtacAffichage = new System.Windows.Forms.Label();
            this.btnAfficherTraversee = new System.Windows.Forms.Button();
            this.lvAffichageTraversee = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblSecteursTraversee
            // 
            this.lblSecteursTraversee.AutoSize = true;
            this.lblSecteursTraversee.Location = new System.Drawing.Point(27, 31);
            this.lblSecteursTraversee.Name = "lblSecteursTraversee";
            this.lblSecteursTraversee.Size = new System.Drawing.Size(55, 13);
            this.lblSecteursTraversee.TabIndex = 1;
            this.lblSecteursTraversee.Text = "Secteurs :";
            // 
            // lbxSecteursTraversee
            // 
            this.lbxSecteursTraversee.FormattingEnabled = true;
            this.lbxSecteursTraversee.Location = new System.Drawing.Point(30, 71);
            this.lbxSecteursTraversee.Name = "lbxSecteursTraversee";
            this.lbxSecteursTraversee.Size = new System.Drawing.Size(184, 225);
            this.lbxSecteursTraversee.TabIndex = 6;
            this.lbxSecteursTraversee.SelectedIndexChanged += new System.EventHandler(this.lbxSecteursTraversee_SelectedIndexChanged);
            // 
            // lblLiaisonTraversee
            // 
            this.lblLiaisonTraversee.AutoSize = true;
            this.lblLiaisonTraversee.Location = new System.Drawing.Point(27, 326);
            this.lblLiaisonTraversee.Name = "lblLiaisonTraversee";
            this.lblLiaisonTraversee.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonTraversee.TabIndex = 7;
            this.lblLiaisonTraversee.Text = "Liaison :";
            // 
            // cmbLiaisonTraversee
            // 
            this.cmbLiaisonTraversee.FormattingEnabled = true;
            this.cmbLiaisonTraversee.Location = new System.Drawing.Point(30, 373);
            this.cmbLiaisonTraversee.Name = "cmbLiaisonTraversee";
            this.cmbLiaisonTraversee.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonTraversee.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblDtacAffichage
            // 
            this.lblDtacAffichage.AutoSize = true;
            this.lblDtacAffichage.Location = new System.Drawing.Point(291, 49);
            this.lblDtacAffichage.Name = "lblDtacAffichage";
            this.lblDtacAffichage.Size = new System.Drawing.Size(36, 13);
            this.lblDtacAffichage.TabIndex = 13;
            this.lblDtacAffichage.Text = "Date :";
            // 
            // btnAfficherTraversee
            // 
            this.btnAfficherTraversee.Location = new System.Drawing.Point(368, 370);
            this.btnAfficherTraversee.Name = "btnAfficherTraversee";
            this.btnAfficherTraversee.Size = new System.Drawing.Size(75, 23);
            this.btnAfficherTraversee.TabIndex = 14;
            this.btnAfficherTraversee.Text = "Afficher";
            this.btnAfficherTraversee.UseVisualStyleBackColor = true;
            // 
            // lvAffichageTraversee
            // 
            this.lvAffichageTraversee.HideSelection = false;
            this.lvAffichageTraversee.Location = new System.Drawing.Point(255, 96);
            this.lvAffichageTraversee.Name = "lvAffichageTraversee";
            this.lvAffichageTraversee.Size = new System.Drawing.Size(483, 243);
            this.lvAffichageTraversee.TabIndex = 15;
            this.lvAffichageTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // FormAffichageTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAffichageTraversee);
            this.Controls.Add(this.btnAfficherTraversee);
            this.Controls.Add(this.lblDtacAffichage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbLiaisonTraversee);
            this.Controls.Add(this.lblLiaisonTraversee);
            this.Controls.Add(this.lbxSecteursTraversee);
            this.Controls.Add(this.lblSecteursTraversee);
            this.Name = "FormAffichageTraversee";
            this.Text = "FormAffichageTraversee";
            this.Load += new System.EventHandler(this.FormAffichageTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteursTraversee;
        private System.Windows.Forms.ListBox lbxSecteursTraversee;
        private System.Windows.Forms.Label lblLiaisonTraversee;
        private System.Windows.Forms.ComboBox cmbLiaisonTraversee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDtacAffichage;
        private System.Windows.Forms.Button btnAfficherTraversee;
        private System.Windows.Forms.ListView lvAffichageTraversee;
    }
}