using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormAffichageReservation : Form
    {
        public FormAffichageReservation()
        {
            InitializeComponent();
        }

        private void FormAffichageReservation_Load(object sender, EventArgs e)
        {
            lvTableauReservation.View = View.Details;
            lvTableauReservation.GridLines = true;
            lvTableauReservation.FullRowSelect = true;
            lvTableauReservation.Columns.Add("N° Réservation", 100);
            lvTableauReservation.Columns.Add("Liaison", 150);
            lvTableauReservation.Columns.Add("N° Traversée", 100);
            lvTableauReservation.Columns.Add("Date Départ", 150);

            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {
                ////////////////Selection client////////////////

                maCo.Open();

                requête = "Select noclient, nom, prenom from client c";
                maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    int noClient = (int)jeuEnregistrements["noclient"];
                    string nomClient = (string)jeuEnregistrements["nom"];
                    string prenomClient = (string)jeuEnregistrements["prenom"];
                    cmbNomReservation.Items.Add(new Client(noClient, nomClient, prenomClient));
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

        private void cmbNomReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;


            maCnx.Open();
            try
            {
                int noClient = ((Client)cmbNomReservation.SelectedItem).GetNoClient();
                var tabItem = new string[4];

                requete = "Select noreservation, t.noliaison, t.notraversee, pd.NOM as nomDepart, pa.NOM as nomArrivee, dateheuredepart " +
                    "from reservation r " +
                    "inner join traversee t on (r.notraversee = t.notraversee) " +
                    "inner join liaison  l on (t.noliaison = l.noliaison)" +
                    "inner join port pd on (l.NOPORT_DEPART = pd.NOPORT) " +
                    "inner join port pa on (l.NOPORT_ARRIVEE = pa.NOPORT)" +
                    "where noclient = @noclient";
                maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noclient", noClient);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();

                while (jeuEnregistrements.Read())
                {
                    int noReservation = (int)jeuEnregistrements["noreservation"];
                    int noTraverse = (int)jeuEnregistrements["notraversee"];
                    DateTime dateHeureDepart = (DateTime)jeuEnregistrements["dateheuredepart"];
                    int noLiaison = (int)jeuEnregistrements["noliaison"];
                    string nomPortDepart = (string)(jeuEnregistrements["nomDepart"].ToString());
                    string nomPortArrivee = (string)(jeuEnregistrements["nomArrivee"].ToString());
                    Liaison liason = new Liaison(noLiaison, nomPortDepart, nomPortArrivee);

                    tabItem[0] = noReservation.ToString();
                    tabItem[1] = liason.ToString();
                    tabItem[2] = noTraverse.ToString();
                    tabItem[3] = dateHeureDepart.ToString();

                    lvTableauReservation.Items.Add(new ListViewItem(tabItem));
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

        private void lvTableauReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde, maCdeReservation;

            try
            {
                maCo.Open();
                int noClient = ((Client)cmbNomReservation.SelectedItem).GetNoClient();
                int noReservation = 0;
                requête = "Select noreservation from reservation where noclient = @noclient";
                maCdeReservation = new MySqlCommand(requête, maCo);
                maCdeReservation.Parameters.AddWithValue("@noclient", noClient);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCdeReservation.ExecuteReader();

                while (jeuEnregistrements.Read())
                {
                    noReservation = Convert.ToInt32(jeuEnregistrements["noreservation"]);
                }
                jeuEnregistrements.Close();

                requête = "SELECT * from enregistrer e " +
                            "inner join type t on e.NOTYPE = t.NOTYPE " +
                            "inner join reservation r on  e.NORESERVATION = r.NORESERVATION " +
                            "where t.LETTRECATEGORIE= e.LETTRECATEGORIE and e.NOTYPE = t.NOTYPE " +
                            "and e.NORESERVATION = @noreservation";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@noreservation", noReservation);
                jeuEnregistrements = maCde.ExecuteReader();

                int i = 0;
                double montantTotal = 0;
                string modeReglement = "";

                while (jeuEnregistrements.Read())
                {
                    string lettreCategorie = jeuEnregistrements["lettrecategorie"].ToString();
                    int noType = Convert.ToInt32(jeuEnregistrements["notype"]);
                    string libelle = jeuEnregistrements["libelle"].ToString();
                    int quantiteReservee = Convert.ToInt32(jeuEnregistrements["quantitereservee"]);
                    montantTotal = Convert.ToDouble(jeuEnregistrements["montanttotal"]);
                    modeReglement = jeuEnregistrements["modereglement"].ToString();

                    if(i == 0)
                    {
                        lblMontantAdulte.Text = quantiteReservee.ToString();
                    }
                    else if(i == 1)
                    {
                        lblMontantJunior.Text = quantiteReservee.ToString();
                    }
                    else if(i == 2)
                    {
                        lblMontantEnfant.Text = quantiteReservee.ToString();
                    }
                    else if(i == 3)
                    {
                        lblMontantVoitMoins4.Text = quantiteReservee.ToString();
                    }

                    i ++;
                }

                jeuEnregistrements.Close();

                lblMontantResultat.Text = montantTotal.ToString() + " €";
                lblReglementResultat.Text = modeReglement;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}