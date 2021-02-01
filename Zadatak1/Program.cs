using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak1
{
    class Program
    {
        public static void AktivirajSe(Životinja životinja)
        {
            životinja.KrećemSe();
            životinja.GlasamSe();
        }

        public static void Main()
        {
            //AktivirajSe(new Vrana());  // trebalo bi ispisati: "Letim krilima" i "Kra, kra"
            //AktivirajSe(new Mačka());  // trebalo bi ispisati: "Krećem se nogama" i "Mijau"
            //AktivirajSe(new Vrabac()); // trebalo bi ispisati: "Letim krilima" i "Živ, živ"
            //AktivirajSe(new Pas());    // trebalo bi ispisati: "Krećem se nogama" i "Vau, vau"
        }
    }
}
