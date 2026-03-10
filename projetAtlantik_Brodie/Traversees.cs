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
        private string dateHeureDepart;
        private string dateHeureArrive;

        public Traversees(int noTraverse, string dateHeureDepart, string dateHeureArrive)
        {
            this.noTraverse = noTraverse;
            this.dateHeureDepart = dateHeureDepart;
            this.dateHeureArrive = dateHeureArrive;
        }

        public int getNoTraverse()
        {
            return noTraverse;
        }
    }
}
