using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace projetAtlantik_Brodie
{
    internal class Liaison
    {
        private int noLiaison;
        private string nomPortDepart;
        private string nomPortArrivee;

        public Liaison(int noLiaison, string nomPort_Depart, string nomPort_Arrivee)
        {
            this.noLiaison = noLiaison;
            this.nomPortDepart = nomPort_Depart;
            this.nomPortArrivee = nomPort_Arrivee;
        }

        public int GetNoLiaison() 
        { 
            return noLiaison;
        }

        public override string ToString()
        {
            return nomPortDepart + " - " + nomPortArrivee;
        }
    }
}
