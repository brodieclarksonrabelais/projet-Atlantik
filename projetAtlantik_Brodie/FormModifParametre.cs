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

namespace projetAtlantik_Brodie
{
    public partial class FormModifParametre : Form
    {
        public FormModifParametre()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormModifParametre_Load(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            MySqlCommand maCde;

            try
            {
                maCnx.Open();

                requete = "Select * from parametres";
                maCde = new MySqlCommand(requete, maCnx);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    string site = jeuEnregistrements["SITE_PB"].ToString();
                    string rang = jeuEnregistrements["RANG_PB"].ToString();
                    string identifiant = jeuEnregistrements["IDENTIFIANT_PB"].ToString();
                    string cleHMAC = jeuEnregistrements["CLEHMAC_PB"].ToString();
                    int enProduction = Convert.ToInt32(jeuEnregistrements["ENPRODUCTION"]);
                    string mel = jeuEnregistrements["MELSITE"].ToString();

                    tbxSite.Text = site;
                    tbxRang.Text = rang;
                    tbxID.Text = identifiant;
                    tbxCleHMAC.Text = cleHMAC;
                    tbxMel.Text = mel;
                }
                jeuEnregistrements.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCnx.Close();
            }
        }

        private void btnModifParametres_Click(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            MySqlCommand maCde;

            if (tbxMel.Text == null || tbxID.Text == null || tbxCleHMAC.Text == null || tbxRang.Text == null || tbxSite.Text == null)
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                try
                {
                    maCnx.Open();
                    string site = tbxSite.Text;
                    string rang = tbxRang.Text;
                    string identifiant = tbxID.Text;
                    string cleHMAC = tbxCleHMAC.Text;
                    string mel = tbxMel.Text;
                    int enProduction = Convert.ToInt32(cbxEnProduction.Checked);

                    requete = "Update parametres set SITE_PB = @SITE_PB, RANG_PB = @RANG_PB, IDENTIFIANT_PB = @IDENTIFIANT_PB, CLEHMAC_PB = @CLEHMAC_PB, ENPRODUCTION = @ENPRODUCTION , MELSITE = @MELSITE";
                    maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@SITE_PB", site);
                    maCde.Parameters.AddWithValue("@RANG_PB", rang);
                    maCde.Parameters.AddWithValue("@IDENTIFIANT_PB", identifiant);
                    maCde.Parameters.AddWithValue("@CLEHMAC_PB", cleHMAC);
                    maCde.Parameters.AddWithValue("@ENPRODUCTION", enProduction);
                    maCde.Parameters.AddWithValue("@MELSITE", mel);
                    maCde.ExecuteNonQuery();

                    MessageBox.Show("Vos paramètres ont été modifiés avec succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    maCnx.Close();
                }
            }
        }

        private void tbxSite_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbxRang_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbxMel_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            var resultatTest = objetRegEx.Match(tbxMel.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxMel.BackColor = Color.Red;

            }
        }

        private void tbxMel_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnModifParametres.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnModifParametres.Enabled = true;
            }
        }

        private void tbxMel_Validated(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxMel.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxMel.BackColor = Color.Red;
            }
        }
    }
}
