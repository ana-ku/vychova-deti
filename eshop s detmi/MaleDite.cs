using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_s_detmi
{
    public class MaleDite : ZakladniDite, IDostanVyprask
    {

        public MaleDite() : base(1) { }

        public string DostanVyprask()
        {
         JeHodne = true;
         return "Už jsem hodné";
        }

        public override void PredstavSe()
        {
            Console.WriteLine("Jsem malé dítě. Jmenuji se " + Jmeno + " a je mi " + Vek + " let." + (JeHodne ? " Jsem hodné": " Nejsem hodné") );
        }

        public void UmiNositVodu(int indexUzitecnosti)
        {
            Uzitecnost += indexUzitecnosti; 
        }
    }
}
