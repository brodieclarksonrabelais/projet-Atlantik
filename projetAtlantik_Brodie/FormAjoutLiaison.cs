using MySql.Data.MySqlClient;
using Npgsql;
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
    public partial class FormAjoutLiaison : Form
    {
        public FormAjoutLiaison()
        {
            InitializeComponent();
        }

        private void btnAjoutLiaison_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {
                maCo.Open();
                Int32 n;
                
                // /////////// AFFECTATION D'UN SECTEUR 
                string secteurLu = lbxSecteurs.Text;
                do
                {
                    Console.WriteLine("Auteur (Nom, Prénom) ?");
                    secteurLu = Console.ReadLine();
                    requête = "select count(*) FROM secteur WHERE secteur=@secteur";
                    maCde = new MySqlCommand(requête, maCo);
                    maCde.Parameters.AddWithValue("@secteur", secteurLu);
                    n = Convert.ToInt32(maCde.ExecuteScalar());
                    if (n == 0)
                    {
                        Console.WriteLine("Pas d'auteur avec ce nom.");
                    }
                }
                while (n != 1);
                requête = "select nosecteur FROM secteur WHERE secteur=@secteur";

                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@secteur", secteurLu);

                MySqlDataReader jeuEnregistrements;
                jeuEnregistrements = maCde.ExecuteReader();
                jeuEnregistrements.Read();
                int numeroecteur;
                IdentifiantAuteur = Convert.ToInt32(jeuEnregistrements["au_id"]);
                jeuEnregistrements.Close();
                // INSERTION dans titleauthor
                requête = "Insert into titleauthor values (@isbn, @au_id)";
                maCde = new NpgsqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@isbn", isbnLu);
                maCde.Parameters.AddWithValue("@au_id", IdentifiantAuteur);

                n = maCde.ExecuteNonQuery();
                Console.WriteLine("\nInsertion de " + n.ToString() + " ligne(s) dans titleauthor\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
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
    }
}
