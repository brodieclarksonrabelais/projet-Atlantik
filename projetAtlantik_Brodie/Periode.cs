using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Periode
    {
        private int noperiode;
        private string datedebut;
        private string datefin;

        public Periode(int noperiode, string datedebut, string datefin)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }

        public int GetNoperiode() 
        { 
            return noperiode; 
        }

        public override string ToString()
        {
            return datedebut + " au " + datefin;
        }

    }
}
