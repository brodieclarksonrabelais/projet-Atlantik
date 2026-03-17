namespace projetAtlantik_Brodie
{
    partial class FormAjoutTarif
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
            this.lbxSecteurTarif = new System.Windows.Forms.ListBox();
            this.lblSecteursTarif = new System.Windows.Forms.Label();
            this.cmbLiaisonTarif = new System.Windows.Forms.ComboBox();
            this.lblLiaisonTarif = new System.Windows.Forms.Label();
            this.lblPeriodeTarif = new System.Windows.Forms.Label();
            this.cmbPeriodeTarif = new System.Windows.Forms.ComboBox();
            this.gbxCategorieTarif = new System.Windows.Forms.GroupBox();
            this.lblTarif = new System.Windows.Forms.Label();
            this.btnAjoutTarif = new System.Windows.Forms.Button();
            this.gbxCategorieTarif.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxSecteurTarif
            // 
            this.lbxSecteurTarif.FormattingEnabled = true;
            this.lbxSecteurTarif.Location = new System.Drawing.Point(29, 37);
            this.lbxSecteurTarif.Name = "lbxSecteurTarif";
            this.lbxSecteurTarif.Size = new System.Drawing.Size(120, 186);
            this.lbxSecteurTarif.TabIndex = 0;
            this.lbxSecteurTarif.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurTarif_SelectedIndexChanged);
            // 
            // lblSecteursTarif
            // 
            this.lblSecteursTarif.AutoSize = true;
            this.lblSecteursTarif.Location = new System.Drawing.Point(29, 9);
            this.lblSecteursTarif.Name = "lblSecteursTarif";
            this.lblSecteursTarif.Size = new System.Drawing.Size(55, 13);
            this.lblSecteursTarif.TabIndex = 1;
            this.lblSecteursTarif.Text = "Secteurs :";
            // 
            // cmbLiaisonTarif
            // 
            this.cmbLiaisonTarif.FormattingEnabled = true;
            this.cmbLiaisonTarif.Location = new System.Drawing.Point(29, 278);
            this.cmbLiaisonTarif.Name = "cmbLiaisonTarif";
            this.cmbLiaisonTarif.Size = new System.Drawing.Size(170, 21);
            this.cmbLiaisonTarif.TabIndex = 2;
            this.cmbLiaisonTarif.SelectedIndexChanged += new System.EventHandler(this.cmbLiaisonTarif_SelectedIndexChanged);
            // 
            // lblLiaisonTarif
            // 
            this.lblLiaisonTarif.AutoSize = true;
            this.lblLiaisonTarif.Location = new System.Drawing.Point(25, 246);
            this.lblLiaisonTarif.Name = "lblLiaisonTarif";
            this.lblLiaisonTarif.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonTarif.TabIndex = 3;
            this.lblLiaisonTarif.Text = "Liaison :";
            // 
            // lblPeriodeTarif
            // 
            this.lblPeriodeTarif.AutoSize = true;
            this.lblPeriodeTarif.Location = new System.Drawing.Point(26, 347);
            this.lblPeriodeTarif.Name = "lblPeriodeTarif";
            this.lblPeriodeTarif.Size = new System.Drawing.Size(49, 13);
            this.lblPeriodeTarif.TabIndex = 4;
            this.lblPeriodeTarif.Text = "Periode :";
            // 
            // cmbPeriodeTarif
            // 
            this.cmbPeriodeTarif.FormattingEnabled = true;
            this.cmbPeriodeTarif.Location = new System.Drawing.Point(28, 374);
            this.cmbPeriodeTarif.Name = "cmbPeriodeTarif";
            this.cmbPeriodeTarif.Size = new System.Drawing.Size(244, 21);
            this.cmbPeriodeTarif.TabIndex = 5;
            // 
            // gbxCategorieTarif
            // 
            this.gbxCategorieTarif.Controls.Add(this.lblTarif);
            this.gbxCategorieTarif.Location = new System.Drawing.Point(388, 37);
            this.gbxCategorieTarif.Name = "gbxCategorieTarif";
            this.gbxCategorieTarif.Size = new System.Drawing.Size(400, 323);
            this.gbxCategorieTarif.TabIndex = 6;
            this.gbxCategorieTarif.TabStop = false;
            this.gbxCategorieTarif.Text = "Catégories";
            this.gbxCategorieTarif.TextChanged += new System.EventHandler(this.gbxCategorieTarif_TextChanged);
            this.gbxCategorieTarif.Validating += new System.ComponentModel.CancelEventHandler(this.gbxCategorieTarif_Validating);
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(203, 0);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(33, 13);
            this.lblTarif.TabIndex = 1;
            this.lblTarif.Text = "Tarifs";
            this.lblTarif.Click += new System.EventHandler(this.lblTarif_Click);
            // 
            // btnAjoutTarif
            // 
            this.btnAjoutTarif.Location = new System.Drawing.Point(350, 405);
            this.btnAjoutTarif.Name = "btnAjoutTarif";
            this.btnAjoutTarif.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutTarif.TabIndex = 7;
            this.btnAjoutTarif.Text = "Ajouter";
            this.btnAjoutTarif.UseVisualStyleBackColor = true;
            this.btnAjoutTarif.Click += new System.EventHandler(this.btnAjoutTarif_Click);
            // 
            // FormAjoutTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjoutTarif);
            this.Controls.Add(this.gbxCategorieTarif);
            this.Controls.Add(this.cmbPeriodeTarif);
            this.Controls.Add(this.lblPeriodeTarif);
            this.Controls.Add(this.lblLiaisonTarif);
            this.Controls.Add(this.cmbLiaisonTarif);
            this.Controls.Add(this.lblSecteursTarif);
            this.Controls.Add(this.lbxSecteurTarif);
            this.Name = "FormAjoutTarif";
            this.Text = "FormAjoutTarif";
            this.Load += new System.EventHandler(this.FormAjoutTarif_Load);
            this.gbxCategorieTarif.ResumeLayout(false);
            this.gbxCategorieTarif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurTarif;
        private System.Windows.Forms.Label lblSecteursTarif;
        private System.Windows.Forms.ComboBox cmbLiaisonTarif;
        private System.Windows.Forms.Label lblLiaisonTarif;
        private System.Windows.Forms.Label lblPeriodeTarif;
        private System.Windows.Forms.ComboBox cmbPeriodeTarif;
        private System.Windows.Forms.GroupBox gbxCategorieTarif;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Button btnAjoutTarif;
    }
}