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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace projetAtlantik_Brodie
{
    public partial class FormAjoutTraversee : Form
    {
        public FormAjoutTraversee()
        {
            InitializeComponent();
        }

        private void lbxSecteursTraversee_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            maCo.Open();
            try
            {
                ////////////////Selection liaison////////////////

                int noSecteurLiaison = ((Secteurs)lbxSecteursTraversee.SelectedItem).GetNosecteur();

                requête = "Select noliaison, pd.NOM as nomDepart, pa.NOM as nomArrivee from liaison l inner join port pd on (l.NOPORT_DEPART = pd.NOPORT) inner join port pa on (l.NOPORT_ARRIVEE = pa.NOPORT) where nosecteur = @nosecteur;";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@nosecteur", noSecteurLiaison);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                cmbLiaisonTraversee.Items.Clear();
                while (jeuEnregistrements.Read())
                {
                    int noLiaison = (int)jeuEnregistrements["noliaison"];
                    string nomPortDepart = (string)(jeuEnregistrements["nomDepart"].ToString());
                    string nomPortArrivee = (string)(jeuEnregistrements["nomArrivee"].ToString());
                    cmbLiaisonTraversee.Items.Add(new Liaison(noLiaison, nomPortDepart, nomPortArrivee));
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

        private void FormAjoutTraversee_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

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
                    lbxSecteursTraversee.Items.Add(new Secteurs(noSecteur, nomSecteur));
                }
                jeuEnregistrements.Close();

                ////////////////Selection bateau////////////////

                int noBateau;
                string nomBateau;

                requête = "Select * from bateau";
                maCde = new MySqlCommand(requête, maCo);
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    noBateau = (int)jeuEnregistrements["nobateau"];
                    nomBateau = (string)jeuEnregistrements["nom"];
                    cmbBateauTraversee.Items.Add(new Bateaus(noBateau, nomBateau));
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

        private void btnAjoutTraversee_Click(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            maCnx.Open();
            try
            {
                requete = "insert into traversee(noliaison, nobateau, dateheuredepart, dateheurearrivee) values(@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
                var maCde4 = new MySqlCommand(requete, maCnx);
                maCde4.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaisonTraversee.SelectedItem).GetNoLiaison());
                maCde4.Parameters.AddWithValue("@nobateau", ((Bateaus)cmbBateauTraversee.SelectedItem).getNoBateau());
                maCde4.Parameters.AddWithValue("@dateheuredepart", dateDepart.Value);
                maCde4.Parameters.AddWithValue("@dateheurearrivee", dateArrivee.Value);
                maCde4.ExecuteNonQuery();
                MessageBox.Show("Votre traversee a été ajouté avec succès");
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

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {
            dateArrivee.MinDate = dateDepart.Value;
        }
    }
}
