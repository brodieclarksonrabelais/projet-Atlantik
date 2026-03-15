using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Client
    {
        private int noClient;
        private string nom;
        private string prenom;

        public Client(int noClient, string nom, string prenom)
        {
            this.noClient = noClient;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int getNoClient()
        {
            return noClient;
        }

        public override string ToString()
        {
            return nom + ", " + prenom;
        }
    }
}
