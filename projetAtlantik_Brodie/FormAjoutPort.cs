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
    public partial class FormAjoutPort : Form
    {
        public FormAjoutPort()
        {
            InitializeComponent();
        }

        private void FormAjoutPort_Load(object sender, EventArgs e)
        {

        }

        private void btnAjoutPort_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            maCo = new MySqlConnection("server=localhost;user=root;database=atlantik2024;port=3306");
            string requête;
            MySqlCommand maCde;

            try
            {
                maCo.Open();
                string nom = tbxAjoutPort.Text;

                requête = "Insert into port (nom) values (@nom)";
                maCde = new MySqlCommand(requête, maCo);
                maCde.Parameters.AddWithValue("@nom", nom);

                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Le port a été ajouté avec succès.");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxAjoutPort.Text);

            if (!resultatTest.Success)
            {
                tbxAjoutPort.BackColor = Color.Red;
                btnAjoutPort.Enabled = false;
            }
            else
            {
                tbxAjoutPort.BackColor = Color.White;
                btnAjoutPort.Enabled = true;
            }
        }

        private void tbxAjoutPort_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxAjoutPort.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxAjoutPort.BackColor = Color.Red;

            }
        }
    }
}