using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Bateaus
    {
        private int noBateau;
        private string nomBateau;

        public Bateaus(int noBateau, string nomBateau)
        {
            this.noBateau = noBateau;
            this.nomBateau = nomBateau;
        }

        public int GetNoBateau()
        {
            return noBateau;
        }

        public override string ToString()
        {
            return nomBateau;
        }
    }
}
