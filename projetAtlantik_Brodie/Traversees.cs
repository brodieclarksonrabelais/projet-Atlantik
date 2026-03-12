using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Traversees
    {
        private int noTraverse;
        private DateTime dateHeure;

        public Traversees(int noTraverse, DateTime dateHeureDepart)
        {
            this.noTraverse = noTraverse;
            this.dateHeure = dateHeureDepart;
        }

        public int getNoTraverse()
        {
            return noTraverse;
        }
    }
}
