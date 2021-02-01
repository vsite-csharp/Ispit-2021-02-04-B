using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak3
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Toplomjer toplomjer = new Toplomjer();
            Grijalica grijalica = new Grijalica();

            // ovdje dodati naredbu kojom će se grijalica predbilježiti na događaj toplomjer.PromjenaTemperature:
            // toplomjer.PromjenaTemperature ...

            int[] temperature = new int[] { 21, 20, 20, 16, 5, 21, 22  };

            // Izvođenje donje petlje trebalo bi ispisati:
            //   Toplomjer: nova temperatura je 21 C
            //   Grijalica: i dalje isključena na temperaturi 21 C
            //   Toplomjer: nova temperatura je 20 C
            //   Grijalica: i dalje isključena na temperaturi 20 C
            //   Toplomjer: nova temperatura je 20 C
            //   Toplomjer: nova temperatura je 16 C
            //   Grijalica: uključila se jer je temperatura pala na 16 C
            //   Toplomjer: nova temperatura je 5 C
            //   Grijalica: i dalje uključena na temperaturi 5 C
            //   Toplomjer: nova temperatura je 21 C
            //   Grijalica: i dalje uključena na temperaturi 21 C
            //   Toplomjer: nova temperatura je 22 C
            //   Grijalica: isključila se jer je temperatura narasla na 22 C

            for (int i = 0; i < temperature.Length; ++i)
            {
                toplomjer.NovaTemperatura(temperature[i]);
            }
        }
    }
}
