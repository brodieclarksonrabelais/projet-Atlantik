using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAtlantik_Brodie
{
    internal class Secteurs
    {
        private int noSecteur;
        private string nomSecteur;

        public Secteurs(int noSecteur, string nomSecteur)
        {
            this.noSecteur = noSecteur;
            this.nomSecteur = nomSecteur;
        }

        public int GetNosecteur() 
        {
            return noSecteur; 
        }

        public override string ToString()
        {
            return nomSecteur;
        }
    }
}
