using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 1);
            // Console.WriteLine(kb1.Modul);  // treba ispisati 1,4142...
            // Console.WriteLine(kb1.Argument);  // treba ispisati 0,785398...
            
            KompleksniBroj kb2 = new KompleksniBroj(2, 3);
            //Console.WriteLine(kb1 + kb2); // treba ispisati: 3 + 4i
            //Console.WriteLine(kb1 - kb2); // treba ispisati: -1 - 2i
            //Console.WriteLine(kb1 * kb2); // treba ispisati: -1 + 5i

            // Console.WriteLine(-kb2);  // treba ispisati: -2 - 3i
            // Console.WriteLine(~kb2);  // treba ispisati: 2 - 3i

        }
    }
}
