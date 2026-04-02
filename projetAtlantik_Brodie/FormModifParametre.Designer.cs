namespace projetAtlantik_Brodie
{
    partial class FormModifParametre
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
            this.lblSite = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblCleHMAC = new System.Windows.Forms.Label();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxCleHMAC = new System.Windows.Forms.TextBox();
            this.tbxMel = new System.Windows.Forms.TextBox();
            this.lblMelSite = new System.Windows.Forms.Label();
            this.btnModifParametres = new System.Windows.Forms.Button();
            this.cbxEnProduction = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(44, 31);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 13);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(44, 73);
            this.lblRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(39, 13);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(44, 117);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 13);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "Identifiant :";
            // 
            // lblCleHMAC
            // 
            this.lblCleHMAC.AutoSize = true;
            this.lblCleHMAC.Location = new System.Drawing.Point(44, 162);
            this.lblCleHMAC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCleHMAC.Name = "lblCleHMAC";
            this.lblCleHMAC.Size = new System.Drawing.Size(62, 13);
            this.lblCleHMAC.TabIndex = 3;
            this.lblCleHMAC.Text = "Clé HMAC :";
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(161, 31);
            this.tbxSite.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(180, 20);
            this.tbxSite.TabIndex = 4;
            this.tbxSite.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSite_Validating);
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(161, 67);
            this.tbxRang.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(76, 20);
            this.tbxRang.TabIndex = 5;
            this.tbxRang.Validating += new System.ComponentModel.CancelEventHandler(this.tbxRang_Validating);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(161, 117);
            this.tbxID.Margin = new System.Windows.Forms.Padding(2);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(180, 20);
            this.tbxID.TabIndex = 6;
            // 
            // tbxCleHMAC
            // 
            this.tbxCleHMAC.Location = new System.Drawing.Point(161, 162);
            this.tbxCleHMAC.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCleHMAC.Name = "tbxCleHMAC";
            this.tbxCleHMAC.Size = new System.Drawing.Size(431, 20);
            this.tbxCleHMAC.TabIndex = 7;
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(161, 213);
            this.tbxMel.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(180, 20);
            this.tbxMel.TabIndex = 8;
            this.tbxMel.TextChanged += new System.EventHandler(this.tbxMel_TextChanged);
            this.tbxMel.Validating += new System.ComponentModel.CancelEventHandler(this.tbxMel_Validating);
            this.tbxMel.Validated += new System.EventHandler(this.tbxMel_Validated);
            // 
            // lblMelSite
            // 
            this.lblMelSite.AutoSize = true;
            this.lblMelSite.Location = new System.Drawing.Point(46, 213);
            this.lblMelSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMelSite.Name = "lblMelSite";
            this.lblMelSite.Size = new System.Drawing.Size(49, 13);
            this.lblMelSite.TabIndex = 9;
            this.lblMelSite.Text = "Mél site :";
            // 
            // btnModifParametres
            // 
            this.btnModifParametres.Location = new System.Drawing.Point(257, 304);
            this.btnModifParametres.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifParametres.Name = "btnModifParametres";
            this.btnModifParametres.Size = new System.Drawing.Size(56, 19);
            this.btnModifParametres.TabIndex = 10;
            this.btnModifParametres.Text = "Modifier";
            this.btnModifParametres.UseVisualStyleBackColor = true;
            this.btnModifParametres.Click += new System.EventHandler(this.btnModifParametres_Click);
            // 
            // cbxEnProduction
            // 
            this.cbxEnProduction.AutoSize = true;
            this.cbxEnProduction.Location = new System.Drawing.Point(161, 258);
            this.cbxEnProduction.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEnProduction.Name = "cbxEnProduction";
            this.cbxEnProduction.Size = new System.Drawing.Size(92, 17);
            this.cbxEnProduction.TabIndex = 11;
            this.cbxEnProduction.Text = "En production";
            this.cbxEnProduction.UseVisualStyleBackColor = true;
            this.cbxEnProduction.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormModifParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cbxEnProduction);
            this.Controls.Add(this.btnModifParametres);
            this.Controls.Add(this.lblMelSite);
            this.Controls.Add(this.tbxMel);
            this.Controls.Add(this.tbxCleHMAC);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.tbxRang);
            this.Controls.Add(this.tbxSite);
            this.Controls.Add(this.lblCleHMAC);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblRang);
            this.Controls.Add(this.lblSite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModifParametre";
            this.Text = "FormModifParametre";
            this.Load += new System.EventHandler(this.FormModifParametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblCleHMAC;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxCleHMAC;
        private System.Windows.Forms.TextBox tbxMel;
        private System.Windows.Forms.Label lblMelSite;
        private System.Windows.Forms.Button btnModifParametres;
        private System.Windows.Forms.CheckBox cbxEnProduction;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}