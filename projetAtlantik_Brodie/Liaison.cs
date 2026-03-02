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
        private int noPort_Depart;
        private int noPort_Arrivee;
        private int distance;

        public Liaison(int noLiaison, int noPort_Depart, int noPort_Arrivee, int distance)
        {
            this.noLiaison = noLiaison;
            this.noPort_Depart = noPort_Depart;
            this.noPort_Arrivee = noPort_Arrivee;
            this.distance = distance;
        }

        public int GetNoLiaison() 
        { 
            return noLiaison;
        }

        public int GetDistance() 
        {
            return distance;
        }
    }
}
