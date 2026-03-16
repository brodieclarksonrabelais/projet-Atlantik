using MySql.Data.MySqlClient;
using Npgsql;
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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace projetAtlantik_Brodie
{
    public partial class FormAjoutLiaison : Form
    {
        public FormAjoutLiaison()
        {
            InitializeComponent();
        }

        private void btnAjoutLiaison_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx4;
            maCnx4 = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306;password=");

            try
            {
                double distance = double.Parse(tbxDistance.Text);
                string requete;
                maCnx4.Open();
                requete = "insert into liaison(NOPORT_DEPART,NOSECTEUR, NOPORT_ARRIVEE,DISTANCE) values(@noportdepart,@nosecteur,@noportarrivee,@distance)";
                var maCde4 = new MySqlCommand(requete, maCnx4);
                maCde4.Parameters.AddWithValue("@nosecteur", ((Secteurs)lbxSecteurs.SelectedItem).GetNosecteur());
                maCde4.Parameters.AddWithValue("@noportdepart", ((Ports)cmbDepart.SelectedItem).GetNoPorts());
                maCde4.Parameters.AddWithValue("@noportarrivee", ((Ports)cmbArrivee.SelectedItem).GetNoPorts());
                maCde4.Parameters.AddWithValue("@distance", distance);
                maCde4.ExecuteNonQuery();

                MessageBox.Show("La liaison à été ajouté avec succès.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (maCnx4 is object & maCnx4.State == ConnectionState.Open)
                {
                    maCnx4.Close(); //déconnection
                }
            }
            Console.ReadLine();
            maCnx4.Close();
        }

        private void FormAjoutLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;
            MySqlConnection maCo2;
            maCo2 = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            MySqlCommand maCde2;
            MySqlConnection maCo3;
            maCo3 = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            MySqlCommand maCde3;

            try
            {
                int noSecteur;
                string nomSecteur;
                maCo.Open();
                requête = "Select * from secteur";
                maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    noSecteur = (int)jeuEnregistrements["nosecteur"];
                    nomSecteur = (string)jeuEnregistrements["nom"];
                    lbxSecteurs.Items.Add(new Secteurs(noSecteur, nomSecteur));
                }
                jeuEnregistrements.Close();

                int noPortsDepart;
                string nomPortsDepart;
                maCo2.Open();
                requête = "Select * from port";
                maCde2 = new MySqlCommand(requête, maCo2);
                jeuEnregistrements = maCde2.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    noPortsDepart = (int)jeuEnregistrements["noport"];
                    nomPortsDepart = (string)jeuEnregistrements["nom"];
                    cmbDepart.Items.Add(new Ports(noPortsDepart, nomPortsDepart));
                }
                jeuEnregistrements.Close();

                int noPortsArrivee;
                string nomPortsArrivee;
                maCo3.Open();
                requête = "Select * from port";
                maCde3 = new MySqlCommand(requête, maCo3);
                jeuEnregistrements = maCde3.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    noPortsArrivee = (int)jeuEnregistrements["noport"];
                    nomPortsArrivee = (string)jeuEnregistrements["nom"];
                    cmbArrivee.Items.Add(new Ports(noPortsArrivee, nomPortsArrivee));
                }
                jeuEnregistrements.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                maCo.Close();
                maCo2.Close();
                maCo3.Close();
            }
        }

        private void tbxDistance_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbxDistance.Text);

            if (!resultatTest.Success)
            {
                tbxDistance.BackColor = Color.Red;
                btnAjoutLiaison.Enabled = false;
            }
            else
            {
                tbxDistance.BackColor = Color.White;
                btnAjoutLiaison.Enabled = true;
            }
        }

        private void btnAjoutLiaison_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbxDistance.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxDistance.BackColor = Color.Red;

            }
        }
    }
}
