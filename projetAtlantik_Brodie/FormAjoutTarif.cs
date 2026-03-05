using MySql.Data.MySqlClient;
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
                    tbxCategorie.Location = new Point(200, i * 15);
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
    }
}
