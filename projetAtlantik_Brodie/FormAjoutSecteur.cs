using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetAtlantik_Brodie
{
    public partial class FormAjoutSecteur : Form
    {
        public FormAjoutSecteur()
        {
            InitializeComponent();
        }

        private void btnAjoutSecteur_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo; 
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306" );
            string requête;
            MySqlCommand maCde;

            try
            {
                maCo.Open();
                string nom = tbxAjoutSecteur.Text;

                requête = "Insert into secteur (nom) values (@nom)";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@nom", nom);

                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Le secteur a été ajouté avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }

        private void FormAjoutSecteur_Load(object sender, EventArgs e)
        {

        }

        private void tbxAjoutSecteur_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxAjoutSecteur.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxAjoutSecteur.BackColor = Color.Red;
                
            }
        }

        private void tbxAjoutSecteur_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxAjoutSecteur.Text);

            if (!resultatTest.Success)
            {
                tbxAjoutSecteur.BackColor = Color.Red;
                btnAjoutSecteur.Enabled = false;
            }
            else
            {
                tbxAjoutSecteur.BackColor = Color.White;
                btnAjoutSecteur.Enabled = true;
            }
        }
    }
}
