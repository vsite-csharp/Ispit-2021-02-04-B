using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak2
{
    // TODO: Zadatak 2: 
    // 1. U strukturu KompleksniBroj dodati javna svojstva (properties) Modul i Argument koja se
    //    mogu samo dohvaćati (tj. imaju samo get metodu) i koje kao rezultat moraju vraćati
    //    apsolutnu vrijednost (udaljenost od ishodišta), odn. kut kojeg ta duljina zatvara s 
    //    realnom osi.
    // 2. Preopteretiti binarne operatore +, -, * tako da omoguće jednostavne operacije zbrajanja
    //    oduzimanja i množenja dva kompleksna broja.
    // 3. Preopteretiti unarne operatore -, ~ tako da vraćaju negativni, odnosno konjugirani
    //    kompleksni broj.
    // Funkcionalnost provjeriti tako da se otkomentiraju naredbe u metodi Main.

    // UPUTA: za kompleksni broj (x, y):
    //    modul: Math.Sqrt(x * x + y * y)
    //    argument: arctan(y / x) - ZA RAČUNANJE ARCUS TANGENSA KORISTITI FUNKCIJU Math.Atan2(y, x)
    //    negativni broj: (-x, -y)
    //    konjugirani broj: (x, -y)
    // Za dva kompleksna broja (x1, y1) i (x2, y2):
    //    zbroj: (x1 + x2, y1 + y2)
    //    razlika: (x1 - x2, y1 - y2)
    //    umnožak: (x1 * x2 - y1 * y2, x1 * y2 + y1 * x2)

    struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni = 0)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public override string ToString()
        {
            if (RealniDio == 0 && ImaginarniDio != 0)
                return ImaginarnaKomponenta();
            return $"{RealniDio}{ImaginarnaKomponenta()}";
        }

        private string ImaginarnaKomponenta()
        {
            if (ImaginarniDio == 0)
                return "";
            if (RealniDio == 0)
            {
                if (ImaginarniDio == 1)
                    return "i";
                if (ImaginarniDio == -1)
                    return "-i";
                return $"{ImaginarniDio}i";
            }
            if (ImaginarniDio < 0)
                return $" - {-ImaginarniDio}i";
            return $" + {ImaginarniDio}i";
        }

        public readonly double RealniDio;
        public readonly double ImaginarniDio;
    }
}
