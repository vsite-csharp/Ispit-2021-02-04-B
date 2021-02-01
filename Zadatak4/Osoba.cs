using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak4
{
    struct Osoba
    {
        public Osoba(string ime, DateTime datumRođenja)
        {
            Ime = ime;
            DatumRođenja = datumRođenja;
        }

        public override string ToString()
        {
            return $"{Ime}, {DatumRođenja.ToShortDateString()}";
        }

        public readonly string Ime;
        public readonly DateTime DatumRođenja;
    }
}
