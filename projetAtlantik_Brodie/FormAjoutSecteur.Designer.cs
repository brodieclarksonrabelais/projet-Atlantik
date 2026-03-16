namespace projetAtlantik_Brodie
{
    partial class FormAjoutSecteur
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
            this.btnAjoutSecteur = new System.Windows.Forms.Button();
            this.tbxAjoutSecteur = new System.Windows.Forms.TextBox();
            this.lblAjoutSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjoutSecteur
            // 
            this.btnAjoutSecteur.Location = new System.Drawing.Point(380, 260);
            this.btnAjoutSecteur.Name = "btnAjoutSecteur";
            this.btnAjoutSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutSecteur.TabIndex = 0;
            this.btnAjoutSecteur.Text = "Ajouter";
            this.btnAjoutSecteur.UseVisualStyleBackColor = true;
            this.btnAjoutSecteur.Click += new System.EventHandler(this.btnAjoutSecteur_Click);
            // 
            // tbxAjoutSecteur
            // 
            this.tbxAjoutSecteur.Location = new System.Drawing.Point(365, 149);
            this.tbxAjoutSecteur.Name = "tbxAjoutSecteur";
            this.tbxAjoutSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxAjoutSecteur.TabIndex = 1;
            this.tbxAjoutSecteur.TextChanged += new System.EventHandler(this.tbxAjoutSecteur_TextChanged);
            this.tbxAjoutSecteur.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAjoutSecteur_Validating);
            // 
            // lblAjoutSecteur
            // 
            this.lblAjoutSecteur.AutoSize = true;
            this.lblAjoutSecteur.Location = new System.Drawing.Point(198, 152);
            this.lblAjoutSecteur.Name = "lblAjoutSecteur";
            this.lblAjoutSecteur.Size = new System.Drawing.Size(149, 13);
            this.lblAjoutSecteur.TabIndex = 2;
            this.lblAjoutSecteur.Tag = "";
            this.lblAjoutSecteur.Text = "Saisissez le secteur à ajouter :";
            // 
            // FormAjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjoutSecteur);
            this.Controls.Add(this.tbxAjoutSecteur);
            this.Controls.Add(this.btnAjoutSecteur);
            this.Name = "FormAjoutSecteur";
            this.Text = "FormAjoutSecteur";
            this.Load += new System.EventHandler(this.FormAjoutSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutSecteur;
        private System.Windows.Forms.TextBox tbxAjoutSecteur;
        private System.Windows.Forms.Label lblAjoutSecteur;
    }
}