using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Categories
    {
        private string lettrecategorie;
        private string libelle;

        public Categories(string lettrecategorie, string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.libelle = libelle;
        }

        public string GetLettreCategorie()
        { 
            return lettrecategorie;
        }

        public override string ToString()
        {
            return lettrecategorie + " " + libelle;
        }
    }
}
