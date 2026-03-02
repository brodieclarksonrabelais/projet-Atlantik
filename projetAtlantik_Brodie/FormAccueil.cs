using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetAtlantik_Brodie
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unBatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutSecteur formAjoutSecteur = new FormAjoutSecteur();
            formAjoutSecteur.ShowDialog();
        }

        private void lesDétailsPourUneRéservationPourUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutPort formAjoutPort = new FormAjoutPort();
            formAjoutPort.ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutLiaison formAjoutLiaison = new FormAjoutLiaison();
            formAjoutLiaison.ShowDialog();
        }
    }
}
