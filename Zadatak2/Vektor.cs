using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak2
{
    // TODO: Zadatak 2: 
    // 1. U strukturu KompleksniBroj dodati svojstvo (property) Modul koje se može samo dohvaćati
    //    (tj. ima samo get metodu) i koje kao rezultat mora vraćati:
    //      Math.Sqrt(RealniDio * RealniDio + ImaginarniDio * ImaginarniDio)
    // 2. Preopteretiti operatore +, -, * i / tako da omoguće jednostavne operacije zbrajanja
    //    oduzimanja, množenja i dijeljenja kompleksnih brojeva.

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
                return " - {-ImaginarniDio}i";
            return " + {ImaginarniDio}i";
        }

        public readonly double RealniDio;
        public readonly double ImaginarniDio;
    }
}
