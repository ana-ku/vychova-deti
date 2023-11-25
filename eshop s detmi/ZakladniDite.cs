using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_s_detmi
{
    public abstract class ZakladniDite
    {
        public double Cena;
        public string Jmeno;
        public int Vek;
        public bool JeHodne;
        public int Uzitecnost;

        public ZakladniDite( int uzitecnost)
        {
            Uzitecnost = uzitecnost;
        }
        public abstract void PredstavSe();

        
        
    }
}
