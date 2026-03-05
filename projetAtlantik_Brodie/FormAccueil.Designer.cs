namespace projetAtlantik_Brodie
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripAccueil = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneLiaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneTraverséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesParamètresDuSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAtlantik = new System.Windows.Forms.Label();
            this.menuStripAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAccueil
            // 
            this.menuStripAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStripAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStripAccueil.Name = "menuStripAccueil";
            this.menuStripAccueil.Size = new System.Drawing.Size(800, 24);
            this.menuStripAccueil.TabIndex = 0;
            this.menuStripAccueil.Text = "menuStrip1";
            this.menuStripAccueil.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSecteurToolStripMenuItem,
            this.unPortToolStripMenuItem,
            this.uneLiaisonToolStripMenuItem,
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem,
            this.unBateauToolStripMenuItem,
            this.uneTraverséToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // unSecteurToolStripMenuItem
            // 
            this.unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            this.unSecteurToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unSecteurToolStripMenuItem.Text = "Un secteur";
            this.unSecteurToolStripMenuItem.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // unPortToolStripMenuItem
            // 
            this.unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            this.unPortToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unPortToolStripMenuItem.Text = "Un port";
            this.unPortToolStripMenuItem.Click += new System.EventHandler(this.unPortToolStripMenuItem_Click);
            // 
            // uneLiaisonToolStripMenuItem
            // 
            this.uneLiaisonToolStripMenuItem.Name = "uneLiaisonToolStripMenuItem";
            this.uneLiaisonToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.uneLiaisonToolStripMenuItem.Text = "Une liaison";
            this.uneLiaisonToolStripMenuItem.Click += new System.EventHandler(this.uneLiaisonToolStripMenuItem_Click);
            // 
            // lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem
            // 
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Name = "lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem";
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Text = "Les tarifs pour une liaison et une période";
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Click += new System.EventHandler(this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem_Click);
            // 
            // unBateauToolStripMenuItem
            // 
            this.unBateauToolStripMenuItem.Name = "unBateauToolStripMenuItem";
            this.unBateauToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unBateauToolStripMenuItem.Text = "Un bateau";
            // 
            // uneTraverséToolStripMenuItem
            // 
            this.uneTraverséToolStripMenuItem.Name = "uneTraverséToolStripMenuItem";
            this.uneTraverséToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.uneTraverséToolStripMenuItem.Text = "Une traversé";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unBatToolStripMenuItem,
            this.lesParamètresDuSiteToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // unBatToolStripMenuItem
            // 
            this.unBatToolStripMenuItem.Name = "unBatToolStripMenuItem";
            this.unBatToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.unBatToolStripMenuItem.Text = "Un bateau";
            this.unBatToolStripMenuItem.Click += new System.EventHandler(this.unBatToolStripMenuItem_Click);
            // 
            // lesParamètresDuSiteToolStripMenuItem
            // 
            this.lesParamètresDuSiteToolStripMenuItem.Name = "lesParamètresDuSiteToolStripMenuItem";
            this.lesParamètresDuSiteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lesParamètresDuSiteToolStripMenuItem.Text = "Les paramètres du site";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem,
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem
            // 
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStrip" +
    "MenuItem";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem.Size = new System.Drawing.Size(519, 22);
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec place restantes par catég" +
    "orie";
            // 
            // lesDétailsPourUneRéservationPourUnClientToolStripMenuItem
            // 
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailsPourUneRéservationPourUnClientToolStripMenuItem";
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem.Size = new System.Drawing.Size(519, 22);
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem.Text = "Les détails pour une réservation pour un client";
            this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem.Click += new System.EventHandler(this.lesDétailsPourUneRéservationPourUnClientToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // lblAtlantik
            // 
            this.lblAtlantik.AutoSize = true;
            this.lblAtlantik.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAtlantik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAtlantik.Location = new System.Drawing.Point(746, 9);
            this.lblAtlantik.Name = "lblAtlantik";
            this.lblAtlantik.Size = new System.Drawing.Size(42, 13);
            this.lblAtlantik.TabIndex = 1;
            this.lblAtlantik.Text = "Atlantik";
            this.lblAtlantik.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAtlantik);
            this.Controls.Add(this.menuStripAccueil);
            this.MainMenuStrip = this.menuStripAccueil;
            this.Name = "FormAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.menuStripAccueil.ResumeLayout(false);
            this.menuStripAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAccueil;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneLiaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneTraverséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label lblAtlantik;
        private System.Windows.Forms.ToolStripMenuItem unBatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesParamètresDuSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlaceRestantesParCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesDétailsPourUneRéservationPourUnClientToolStripMenuItem;
    }
}

