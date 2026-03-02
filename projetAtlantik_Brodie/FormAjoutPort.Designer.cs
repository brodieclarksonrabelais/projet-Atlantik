namespace projetAtlantik_Brodie
{
    partial class FormAjoutPort
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
            this.btnAjoutPort = new System.Windows.Forms.Button();
            this.tbxAjoutPort = new System.Windows.Forms.TextBox();
            this.lblAjoutPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjoutPort
            // 
            this.btnAjoutPort.Location = new System.Drawing.Point(365, 254);
            this.btnAjoutPort.Name = "btnAjoutPort";
            this.btnAjoutPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPort.TabIndex = 0;
            this.btnAjoutPort.Text = "Ajouter";
            this.btnAjoutPort.UseVisualStyleBackColor = true;
            this.btnAjoutPort.Click += new System.EventHandler(this.btnAjoutPort_Click);
            // 
            // tbxAjoutPort
            // 
            this.tbxAjoutPort.Location = new System.Drawing.Point(351, 158);
            this.tbxAjoutPort.Name = "tbxAjoutPort";
            this.tbxAjoutPort.Size = new System.Drawing.Size(100, 20);
            this.tbxAjoutPort.TabIndex = 1;
            this.tbxAjoutPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAjoutPort
            // 
            this.lblAjoutPort.AutoSize = true;
            this.lblAjoutPort.Location = new System.Drawing.Point(195, 161);
            this.lblAjoutPort.Name = "lblAjoutPort";
            this.lblAjoutPort.Size = new System.Drawing.Size(130, 13);
            this.lblAjoutPort.TabIndex = 2;
            this.lblAjoutPort.Text = "Saisissez Le nom du port :";
            // 
            // FormAjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjoutPort);
            this.Controls.Add(this.tbxAjoutPort);
            this.Controls.Add(this.btnAjoutPort);
            this.Name = "FormAjoutPort";
            this.Text = "FormAjoutPort";
            this.Load += new System.EventHandler(this.FormAjoutPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutPort;
        private System.Windows.Forms.TextBox tbxAjoutPort;
        private System.Windows.Forms.Label lblAjoutPort;
    }
}