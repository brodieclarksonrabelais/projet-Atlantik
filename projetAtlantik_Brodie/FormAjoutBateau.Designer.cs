namespace projetAtlantik_Brodie
{
    partial class FormAjoutBateau
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.btnAjoutBateau = new System.Windows.Forms.Button();
            this.gbxCapacites = new System.Windows.Forms.GroupBox();
            this.errorProviderBateau = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTarif = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBateau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(40, 84);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(86, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom du bateau :";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(191, 84);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(135, 20);
            this.tbxNomBateau.TabIndex = 1;
            this.tbxNomBateau.TextChanged += new System.EventHandler(this.tbxNomBateau_TextChanged);
            this.tbxNomBateau.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNomBateau_Validating);
            // 
            // btnAjoutBateau
            // 
            this.btnAjoutBateau.Location = new System.Drawing.Point(356, 376);
            this.btnAjoutBateau.Name = "btnAjoutBateau";
            this.btnAjoutBateau.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutBateau.TabIndex = 2;
            this.btnAjoutBateau.Text = "Ajouter";
            this.btnAjoutBateau.UseVisualStyleBackColor = true;
            this.btnAjoutBateau.Click += new System.EventHandler(this.btnAjoutBateau_Click);
            // 
            // gbxCapacites
            // 
            this.gbxCapacites.Location = new System.Drawing.Point(376, 26);
            this.gbxCapacites.Name = "gbxCapacites";
            this.gbxCapacites.Size = new System.Drawing.Size(374, 344);
            this.gbxCapacites.TabIndex = 3;
            this.gbxCapacites.TabStop = false;
            this.gbxCapacites.Text = "Capacités Maximales";
            // 
            // errorProviderBateau
            // 
            this.errorProviderBateau.ContainerControl = this;
            // 
            // errorProviderTarif
            // 
            this.errorProviderTarif.ContainerControl = this;
            // 
            // FormAjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCapacites);
            this.Controls.Add(this.btnAjoutBateau);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormAjoutBateau";
            this.Text = "FormAjoutBateau";
            this.Load += new System.EventHandler(this.FormAjoutBateau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBateau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Button btnAjoutBateau;
        private System.Windows.Forms.GroupBox gbxCapacites;
        private System.Windows.Forms.ErrorProvider errorProviderBateau;
        private System.Windows.Forms.ErrorProvider errorProviderTarif;
    }
}