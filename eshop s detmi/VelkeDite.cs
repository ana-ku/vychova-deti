using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_s_detmi
{
    public class VelkeDite : ZakladniDite, IDostanVyprask
    {
        public VelkeDite() : base(5) { }

        public string DostanVyprask() // důkaz, že tresty na dětech jsou špatný
        {
            JeHodne = false;
            return "Nenávidím tě";
        }
        public override void PredstavSe()
        {
            Console.WriteLine("Jsem velké dítě. Jmenuji se " + Jmeno + " a je mi " + Vek + " let." + (JeHodne ? " Jsem hodné" : " Nejsem hodné. A výprasky už nepomáhají"));
        }
        
    }
}
