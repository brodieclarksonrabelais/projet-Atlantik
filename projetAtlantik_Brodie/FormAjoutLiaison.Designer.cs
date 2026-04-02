namespace projetAtlantik_Brodie
{
    partial class FormAjoutLiaison
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
            this.components = new System.ComponentModel.Container();
            this.btnAjoutLiaison = new System.Windows.Forms.Button();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutLiaison
            // 
            this.btnAjoutLiaison.Location = new System.Drawing.Point(364, 393);
            this.btnAjoutLiaison.Name = "btnAjoutLiaison";
            this.btnAjoutLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutLiaison.TabIndex = 0;
            this.btnAjoutLiaison.Text = "Ajouter";
            this.btnAjoutLiaison.UseVisualStyleBackColor = true;
            this.btnAjoutLiaison.Click += new System.EventHandler(this.btnAjoutLiaison_Click);
            this.btnAjoutLiaison.Validating += new System.ComponentModel.CancelEventHandler(this.btnAjoutLiaison_Validating);
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(43, 94);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteurs.TabIndex = 1;
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(302, 94);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 2;
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(558, 94);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbArrivee.TabIndex = 3;
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(40, 62);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 4;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(299, 62);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(45, 13);
            this.lblDepart.TabIndex = 5;
            this.lblDepart.Text = "Départ :";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(555, 61);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(46, 13);
            this.lblArrivee.TabIndex = 6;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(40, 274);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Distance :";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(102, 274);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 8;
            this.tbxDistance.TextChanged += new System.EventHandler(this.tbxDistance_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSecteurs);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.btnAjoutLiaison);
            this.Name = "FormAjoutLiaison";
            this.Text = "FormAjoutLiaison";
            this.Load += new System.EventHandler(this.FormAjoutLiaison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutLiaison;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivee;
        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}