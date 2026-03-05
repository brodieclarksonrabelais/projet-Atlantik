using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Ports
    {
        private int noPort;
        private string nomPort;

        public Ports(int noPort, string nomPort)
        {
            this.noPort = noPort;
            this.nomPort = nomPort;
        }

        public int GetNoPorts()
        {
            return noPort;
        }

        public override string ToString()
        {
            return nomPort;
        }
    }
}
