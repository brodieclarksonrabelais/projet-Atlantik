using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FormAjoutTarif : Form
    {
        public FormAjoutTarif()
        {
            InitializeComponent();
        }

        private void FormAjoutTarif_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde, maCde2, maCde3;

            try
            {
                ////////////////Selection secteur////////////////
                
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
                    lbxSecteurTarif.Items.Add(new Secteurs(noSecteur, nomSecteur));
                }
                jeuEnregistrements.Close();

                ////////////////Selection periode////////////////

                requête = "Select * from periode";
                maCde2 = new MySqlCommand(requête, maCo);
                jeuEnregistrements = maCde2.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    int noperiode = Convert.ToInt32(jeuEnregistrements["noperiode"]);
                    string dateDebut = jeuEnregistrements["datedebut"].ToString();
                    string dateFin = jeuEnregistrements["datefin"].ToString();
                    cmbPeriodeTarif.Items.Add(new Periode(noperiode, dateDebut, dateFin));
                }
                jeuEnregistrements.Close();

                requête = "Select * from type";
                maCde3 = new MySqlCommand(requête, maCo);
                jeuEnregistrements = maCde3.ExecuteReader();

                Label lblCategorie;
                TextBox tbxCategorie;
                int i = 0;

                while (jeuEnregistrements.Read())
                {
                    string lettreCategorie = jeuEnregistrements["lettrecategorie"].ToString();
                    int noType = Convert.ToInt32(jeuEnregistrements["notype"]);
                    string libelle = jeuEnregistrements["libelle"].ToString();

                    i += 2;
                    lblCategorie = new Label();
                    lblCategorie.Text = lettreCategorie + noType.ToString() + " - " + libelle;
                    lblCategorie.Location = new Point(0, i * 15);
                    gbxCategorieTarif.Controls.Add(lblCategorie);

                    tbxCategorie = new TextBox();
                    var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
                    var resultatTest = objetRegEx.Match(tbxCategorie.Text);

                    tbxCategorie.Tag = lettreCategorie + ";" + noType; 
                    tbxCategorie.Location = new Point(200, i * 15);
                    tbxCategorie.TextChanged += tbxCategorie_TextChanged;
                    gbxCategorieTarif.Controls.Add(tbxCategorie);

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

        private void cmbLiaisonTarif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxSecteurTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {
                ////////////////Selection liaison////////////////
                
                int noSecteur = ((Secteurs)lbxSecteurTarif.SelectedItem).GetNosecteur();
                maCo.Open();
                requête = "Select noliaison, pd.NOM as nomDepart, pa.NOM as nomArrivee from liaison l inner join port pd on (l.NOPORT_DEPART = pd.NOPORT) inner join port pa on (l.NOPORT_ARRIVEE = pa.NOPORT) where nosecteur = @nosecteur;";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@nosecteur", noSecteur);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                cmbLiaisonTarif.Items.Clear();
                while (jeuEnregistrements.Read())
                {
                    int noLiaison = (int)jeuEnregistrements["noliaison"];
                    string nomPortDepart = (string)(jeuEnregistrements["nomDepart"].ToString());
                    string nomPortArrivee = (string)(jeuEnregistrements["nomArrivee"].ToString());
                    cmbLiaisonTarif.Items.Add(new Liaison(noLiaison, nomPortDepart, nomPortArrivee));
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

        private void lblTarif_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutTarif_Click(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            try
            {
                maCnx.Open();
                if (cmbLiaisonTarif.SelectedItem == null || cmbPeriodeTarif.SelectedItem == null || lbxSecteurTarif == null)
                {
                    MessageBox.Show("Sélectionnez un secteur, une période et une liaison");
                    return;
                }
                else
                {

                    foreach (Control c in gbxCategorieTarif.Controls)
                    {
                        if (c is TextBox tbxCategorie)
                        {

                            TextBox txt = (TextBox)c;

                            string tableau;
                            tableau = (txt.Tag).ToString();
                            tableau.Split(';');

                            string lettreCategorie = tableau[0].ToString();
                            int noType = int.Parse(tableau[2].ToString());
                            double tarif = double.Parse(txt.Text);

                            Periode accesNoPeriode = (Periode)cmbPeriodeTarif.SelectedItem;
                            Liaison accesNoLiaison = (Liaison)cmbLiaisonTarif.SelectedItem;

                            requete = "Insert into tarifer(noperiode, lettrecategorie, notype, noliaison, tarif) values (@noperiode, @lettrecategorie, @notype, @noliaison, @tarif)";
                            var maCde = new MySqlCommand(requete, maCnx);
                            maCde.Parameters.AddWithValue("@noperiode", accesNoPeriode.GetNoperiode());
                            maCde.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                            maCde.Parameters.AddWithValue("@notype", noType);
                            maCde.Parameters.AddWithValue("@noliaison", accesNoLiaison.GetNoLiaison());
                            maCde.Parameters.AddWithValue("@tarif", tarif);
                            maCde.ExecuteNonQuery();

                            MessageBox.Show("Votre tarif a été ajouté avec succès");
                        }
                    }
                }
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

        private void gbxCategorieTarif_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCategorie_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnAjoutTarif.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnAjoutTarif.Enabled = true;
            }
        }
    }
}
