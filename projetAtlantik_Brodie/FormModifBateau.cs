using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FormModifBateau : Form
    {
        public FormModifBateau()
        {
            InitializeComponent();
        }

        private void FormModifBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {
                ////////////////Selection bateau////////////////

                int noBateau;
                string nomBateau;
                maCo.Open();
                requête = "Select * from bateau";
                maCde = new MySqlCommand(requête, maCo);
                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    noBateau = (int)jeuEnregistrements["nobateau"];
                    nomBateau = (string)jeuEnregistrements["nom"];
                    cmbNomBateau.Items.Add(new Bateaus(noBateau, nomBateau));
                }
                jeuEnregistrements.Close();

                requête = "Select * from categorie";
                maCde = new MySqlCommand(requête, maCo);
                jeuEnregistrements = maCde.ExecuteReader();

                Label lblCategorie;
                TextBox tbxCategorie;
                int i = 0;

                while (jeuEnregistrements.Read())
                {
                    string lettreCategorie = jeuEnregistrements["lettrecategorie"].ToString();
                    string libelle = jeuEnregistrements["libelle"].ToString();
                    string capaciteMax = jeuEnregistrements["capacitemax"].ToString();

                    i += 2;
                    lblCategorie = new Label();
                    lblCategorie.Text = lettreCategorie + " - " + libelle;
                    lblCategorie.Location = new Point(0, i * 15);
                    gbxCapaciteMaxModif.Controls.Add(lblCategorie);

                    tbxCategorie = new TextBox();
                    tbxCategorie.Tag = lettreCategorie + ";";
                    tbxCategorie.Text = capaciteMax;
                    tbxCategorie.Location = new Point(200, i * 15);
                    gbxCapaciteMaxModif.Controls.Add(tbxCategorie);
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

        private void cmbNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");

            try
            {
                maCnx.Open();
                string nom = cmbNomBateau.Text;
                requete = "Insert into bateau(nom) values (@nom)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                int noBateau = (int)maCde.LastInsertedId;

                foreach (Control c in gbxCapaciteMaxModif.Controls)
                {
                    if (c is TextBox tbxCategorie)
                    {

                        TextBox txt = (TextBox)c;

                        string tableau;
                        tableau = (txt.Tag).ToString();
                        tableau.Split(';');

                        string lettreCategorie = tableau[0].ToString();
                        int capaciteMax = int.Parse(txt.Text);

                        requete = "Update contenir set lettrecategorie = @lettrecategorie, nobateau = @nobateau, capacitemax = @capacitemax)";
                        var maCde2 = new MySqlCommand(requete, maCnx);
                        maCde2.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                        maCde2.Parameters.AddWithValue("@nobateau", noBateau);
                        maCde2.Parameters.AddWithValue("@capacitemax", capaciteMax);
                        maCde2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Votre bateau a été modifié avec succès");
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
