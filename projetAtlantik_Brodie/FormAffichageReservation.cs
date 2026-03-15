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
                int noClient = ((Client)cmbNomReservation.SelectedItem).getNoClient();
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
            MySqlCommand maCde;

            try
            {

                maCo.Open();
                requête = "Select t.lettrecategorie, t.notype, libelle, montanttotal, modereglement" +
                    "from type t " +
                    "inner join enregistrer e on (t.notype = e.notype)" +
                    "inner join reservation r on (e.noreservation = r.noreservation)";
                maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();

                Label lblCategorie;
                Label lblResultat;
                Label lblMontant;
                int i = 0;

                while (jeuEnregistrements.Read())
                {
                    string lettreCategorie = jeuEnregistrements["lettrecategorie"].ToString();
                    int noType = Convert.ToInt32(jeuEnregistrements["notype"]);
                    string libelle = jeuEnregistrements["libelle"].ToString();


                    i += 2;
                    lblCategorie = new Label();
                    lblCategorie.Text = lettreCategorie + noType.ToString() + " - " + libelle + " :";
                    lblCategorie.Location = new Point(0, i * 15);
                    gbxReservation.Controls.Add(lblCategorie);

                    lblResultat = new Label();
                    lblResultat.Tag = lettreCategorie + ";" + noType;
                    lblResultat.Location = new Point(140, i * 15);
                    gbxReservation.Controls.Add(lblResultat);
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
    }
}
