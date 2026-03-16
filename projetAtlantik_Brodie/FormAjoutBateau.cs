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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace projetAtlantik_Brodie
{
    public partial class FormAjoutBateau : Form
    {
        public FormAjoutBateau()
        {
            InitializeComponent();
        }

        private void FormAjoutBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {

                maCo.Open();
                requête = "Select * from categorie";
                maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();

                Label lblCategorie;
                TextBox tbxCategorie;
                int i = 0;

                while (jeuEnregistrements.Read())
                {
                    string lettreCategorie = jeuEnregistrements["lettrecategorie"].ToString();
                    string libelle = jeuEnregistrements["libelle"].ToString();

                    i += 2;
                    lblCategorie = new Label();
                    lblCategorie.Text = lettreCategorie + " - " + libelle;
                    lblCategorie.Location = new Point(0, i * 15);
                    gbxCapacites.Controls.Add(lblCategorie);

                    tbxCategorie = new TextBox();
                    tbxCategorie.Tag = lettreCategorie + ";";
                    tbxCategorie.Location = new Point(200, i * 15);
                    tbxCategorie.TextChanged += tbxCapacite_TextChanged;
                    gbxCapacites.Controls.Add(tbxCategorie);
                }
                jeuEnregistrements.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }

        private void btnAjoutBateau_Click(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");

            try
            {
                maCnx.Open();
                string nom = tbxNomBateau.Text;
                requete = "Insert into bateau(nom) values (@nom)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                int noBateau = (int)maCde.LastInsertedId;

                foreach (Control c in gbxCapacites.Controls)
                {
                    if (c is TextBox tbxCategorie)
                    {

                        TextBox txt = (TextBox)c;

                        string tableau;
                        tableau = (txt.Tag).ToString();
                        tableau.Split(';');

                        string lettreCategorie = tableau[0].ToString();
                        int capaciteMax = int.Parse(txt.Text);

                        requete = "Insert into contenir(lettrecategorie, nobateau, capacitemax) values (@lettrecategorie, @nobateau, @capacitemax)";
                        var maCde2 = new MySqlCommand(requete, maCnx);
                        maCde2.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                        maCde2.Parameters.AddWithValue("@nobateau", noBateau);
                        maCde2.Parameters.AddWithValue("@capacitemax", capaciteMax);
                        maCde2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Votre bateau a été ajouté avec succès");
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

        private void tbxCapacite_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnAjoutBateau.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnAjoutBateau.Enabled = true;
            }
        }

        private void tbxNomBateau_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnAjoutBateau.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnAjoutBateau.Enabled = true;
            }
        }

        private void tbxNomBateau_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxNomBateau.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxNomBateau.BackColor = Color.Red;

            }
        }
    }
}
