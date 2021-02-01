using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak1
{
    // TODO: Zadatak 1: Složiti klase Životinja, Pas, Mačka, Vrabac i Lastavica u hijerarhiju tako
    // da nema ponavljanja istog koda za metode KrećemSe() te, nakon što se otkomentiraju naredbe 
    // u klasi Program ispis daje očekivane poruke.
    class Životinja
    {
        public void KrećemSe()
        {
        }

        public void GlasamSe()
        {
        }
    }

    class Pas
    {
        public void KrećemSe()
        {
            Console.WriteLine("Krećem se nogama");
        }

        public void GlasamSe()
        {
            Console.WriteLine("Vau, vau");
        }
    }

    class Mačka
    {
        public void KrećemSe()
        {
            Console.WriteLine("Krećem se nogama");
        }

        public void GlasamSe()
        {
            Console.WriteLine("Mijau");
        }
    }

    class Vrabac
    {
        public void KrećemSe()
        {
            Console.WriteLine("Letim krilima");
        }
        public void GlasamSe()
        {
            Console.WriteLine("Živ, živ");
        }
    }

    class Vrana
    {
        public void KrećemSe()
        {
            Console.WriteLine("Letim krilima");
        }
        public void GlasamSe()
        {
            Console.WriteLine("Kra, kra");
        }
    }
}
