using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak5
{
    class Program
    {
        // TODO: Zadatak 5:
        // 1. U metodu IzračunajRedak dodati provjeru sadrži li zadani redak prviBroj, operaciju i 
        //    drugiBroj - ako nema sva tri podatka, treba baciti iznimku tipa ArgumentException s 
        //    porukom "Neispravan izraz". 
        //    Tu iznimku treba hvatati u metodi Main i nakon ispisa poruke treba nastaviti s 
        //    izračunavanjem sljedećeg stringa.
        // 2. U metodi IzračunajRedak treba hvatati iznimku tipa DivideByZeroException i u tom 
        //    slučaju umjesto rezultata ispisati "Dijeljenje nulom".
        // 3. U metodi IzračunajRedak treba hvatati iznimku tipa OverflowException i u tom slučaju 
        //    umjesto rezultata ispisati "Brojčani preljev".
        // 4. U metodi Izračunaj treba, za slučaj da operacija nije podržana (nije +, -, * ili /), 
        //    baciti iznimku tipa NotSupportedException s porukom "Operacija {operacija} nije podržana".
        //    Tu iznimku treba hvatati u metodi Main, ispisati poruku iz iznimke te nastaviti s 
        //    izračunavanjem sljedećeg stringa.

        public static int Izračunaj(int prviBroj, int drugiBroj, string operacija)
        {
            switch (operacija)
            {
                case "+":
                    return prviBroj + drugiBroj;
                case "-":
                    return prviBroj - drugiBroj;
                case "*":
                    return prviBroj * drugiBroj;
                case "/":
                    return prviBroj / drugiBroj;
            }
            return 0;
        }

        public static void IzračunajRedak(string redak)
        {
            var članovi = redak.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            int prviBroj = int.Parse(članovi[0]);
            string operacija = članovi[1];
            int drugiBroj = int.Parse(članovi[2]);

            string izraz = $"{prviBroj} {operacija} {drugiBroj}";

            Console.WriteLine($"{izraz} = {Izračunaj(prviBroj, drugiBroj, operacija)}");
        }

        public static void Main()
        {
            // Nakon traženih prmjena izvođenje programa bi moralo ispisati:
            string[] zaIzračunati = {
                "1 + 4",                           //  1 + 4 = 5
                "5 * 4",                           //  5 * 4 = 20
                "-3 * 2",                          //  -3 * 2 = 6
                "-6 / -2",                         //  -6 / -2 = 3
                "63",                              //  Neispravan izraz
                "12 +",                            //  Neispravan izraz
                "4 / 0",                           //  Dijeljenje nulom
                int.MaxValue.ToString() + " * 2",  //  Brojčani preljev
                " 5 ^ 3",                          //  Operacija ^ nije podržana
                "3 - 5"                            //  3 - 5 = -2
            };


            foreach (var redak in zaIzračunati)
            {
                IzračunajRedak(redak);
            }
        }
    }
}
