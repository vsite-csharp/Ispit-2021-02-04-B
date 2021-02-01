using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak4
{
    class Program
    {
        // TODO: Zadatak 5: Metode IspišiSortiranoPoImenu i IspišiSortiranoPoDatumuRođenja preraditi
        // tako da ispišu zadane osobe sortirane po abecedi, odnosno po datumu rođenja. 
        // NAPOMENA: Definicija strukture Osoba se NE SMIJE MIJENJATI!

        public static void IspišiSortiranoPoImenu(List<Osoba> osobe)
        {
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba);
        }

        public static void IspišiSortiranoPoDatumuRođenja(List<Osoba> osobe)
        {
            foreach (Osoba osoba in osobe)
                Console.WriteLine(osoba);
        }

        static void Main()
        {
            List<Osoba> popisOsoba = new List<Osoba> { 
                new Osoba("Ana", new DateTime(1975, 7, 12)),
                new Osoba("Berislav", new DateTime(1965, 12, 3)),
                new Osoba("Marko", new DateTime(1983, 4, 2)),
                new Osoba("Tomislav", new DateTime(1971, 11, 5)),
                new Osoba("Luka", new DateTime(1995, 3, 15)),
            };

            Console.WriteLine("*** Sortirane po imenu: ***");
            IspišiSortiranoPoImenu(popisOsoba);
            // Trebalo bi ispisati (format datuma ovisi o postavkama u Windowsima):
            //   Ana, 12.07.1975.
            //   Berislav, 03.12.1965.
            //   Luka, 15.03.1995.
            //   Marko, 02.04.1983.
            //   Tomislav, 05.11.1971.

            Console.WriteLine("*** Sortirane po datumu rođenja: ***");
            IspišiSortiranoPoDatumuRođenja(popisOsoba);
            // Trebalo bi ispisati (format datuma ovisi o postavkama u Windowsima):
            //   Berislav, 03.12.1965
            //   Tomislav, 05.11.1971.
            //   Ana, 12.07.1975.
            //   Marko, 02.04.1983.
            //   Luka, 15.03.1995.
        }
    }
}
