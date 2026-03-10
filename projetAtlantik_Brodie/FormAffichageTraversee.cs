using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetAtlantik_Brodie
{
    public partial class FormAffichageTraversee : Form
    {
        public FormAffichageTraversee()
        {
            InitializeComponent();
        }

        private int getQuantiteEnregistree(int pNoTraversee, string pLettreCategorie)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;
            maCo.Open();
            try
            {
                int quantiteReserve = 0;
                requete = "Select sum(quantitereservee) from reservation r inner join enregistrer e on (e.noreservation = r.noreservation) inner join traversee t on (r.notraversee = t.notraversee) where r.notraversee = @notraversee and lettrecategorie = @lettrecategorie;";
                maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@notraversee", pNoTraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", pLettreCategorie);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    quantiteReserve = (int)jeuEnregistrements["sum(quantitereservee)"];
                }
                jeuEnregistrements.Close();
                return quantiteReserve;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                maCo.Close();
            }
        }

        private int getCapaciteMaximale(int pNoTraversee, string pLettreCategorie)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;
            maCo.Open();
            try
            {
                int capacitemax = 0;
                requete = "Select capacitemax from bateau b inner join contenir c on (b.nobateau = c.nobateau) inner join traversee t on (b.nobateau = t.nobateau) where notraversee = @notraversee and lettrecategorie = @lettrecategorie;";
                maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@notraversee", pNoTraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", pLettreCategorie);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    capacitemax = (int)jeuEnregistrements["capacitemax"];
                }
                jeuEnregistrements.Close();
                return capacitemax;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                maCo.Close();
            }
        }

        private List<Categories> GetLesCategories()
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;
            maCo.Open();
            try
            {
                List<Categories> LesCategories = new List<Categories>();
                foreach (Categories c in LesCategories)
                {
                    requete = "Select * from categorie;";
                    maCde = new MySqlCommand(requete, maCo);
                    MySqlDataReader jeuEnregistrements;
                    jeuEnregistrements = maCde.ExecuteReader();
                    while (jeuEnregistrements.Read())
                    {
                        string lettreCategorie = (string)jeuEnregistrements["lettrecategorie"];
                        string libelle = (string)jeuEnregistrements["libelle"];
                        Categories cat = new Categories(lettreCategorie, libelle); 
                        LesCategories.Add(cat);
                    }
                    jeuEnregistrements.Close();
                }
                return LesCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                List<Categories> LesCategories = new List<Categories>();
                return LesCategories;
            }
            finally
            {
                maCo.Close();
            }
        }

        private List<Traversees> GetLesTraverseesBateaux(int pNoLiaison, string pDateTraversee)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;
            maCo.Open();
            try
            {
                List<Traversees> LesTraversees = new List<Traversees>();
                foreach(Traversees t in LesTraversees)
                {
                    requete = "Select notraversee, nom, dateheuredepart from traversee t inner join bateau b on (t.nobateau = b.nobateau) where noliaison = @noliaison and dateheuredepart = @dateheuredepart;";
                    maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@noliaison", pNoLiaison);
                    maCde.Parameters.AddWithValue("@dateheuredepart", pDateTraversee);
                    MySqlDataReader jeuEnregistrements;
                    jeuEnregistrements = maCde.ExecuteReader();
                    while (jeuEnregistrements.Read())
                    {
                        int notraverse = (int)jeuEnregistrements["notraversee"];
                        string nom = (string)jeuEnregistrements["nom"];
                        string dateheuredepart = (string)jeuEnregistrements["dateheuredepart"];
                        Traversees trav = new Traversees(notraverse, nom, dateheuredepart);
                        LesTraversees.Add(trav);
                    }
                    jeuEnregistrements.Close();
                }
                return LesTraversees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                List<Traversees> LesTraversees = new List<Traversees>();
                return LesTraversees;
            }
            finally
            {
                maCo.Close();
            }
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

        private void FormAffichageTraversee_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {

                lvAffichageTraversee.View = View.Details;
                lvAffichageTraversee.GridLines = true;
                lvAffichageTraversee.FullRowSelect = true;

                lvAffichageTraversee.Columns.Add("N°", 70);
                lvAffichageTraversee.Columns.Add("Heure", 50);
                lvAffichageTraversee.Columns.Add("Bateau", 100);
                lvAffichageTraversee.Columns.Add("A\r Passager", 85);
                lvAffichageTraversee.Columns.Add("B\r Véh.inf.2m", 85);
                lvAffichageTraversee.Columns.Add("C\r Véh.sup.2m", 85);

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

        private void btnAfficherTraversee_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requete;
            MySqlCommand maCde;

            maCnx.Open();
            try
            {
               
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
}
