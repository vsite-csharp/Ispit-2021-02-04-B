using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak3
{
    // TODO: Zadatak 3: U klasi Toplomjer treba definirati događaj (event) PromjenaTemperature
    // koji će predbilježenim slušateljima javljati kada se temperatura promijeni. Informaciju 
    // o temperaturi slušateljim prosljeđuje u objektu TemperatureEventArgs.
    // Grijalica i Klima se moraju moći predbilježiti na slušanje događaja PromjenaTemperature.
    // 1. U klasi Toplomjer definirajte događaj Promjena temperature i taj događaj generirajte
    //    iz metode OnPromjenaTemperature.
    // 2. U klasu Grijalica dodajte rukovatelj (handler) preko kojeg će se ona moći predbilježiti
    //    na događaj PromjenaTemperature i iz tog handlera pozovite metodu NaPromjenuTemperature.
    // 3. U metodu Main dodati naredbu kojom će se Grijalica predbilježiti na događaj

    // Klasa kojom se slušateljima prosljeđuje nova temperatura
    class TemperatureEventArgs : EventArgs
    {
        public TemperatureEventArgs(int temperatura)
        {
            Temperatura = temperatura;
        }

        public readonly int Temperatura;
    }

    // Klasa koja generira događaje na promjene temperature
    class Toplomjer
    {
        public delegate void PromjenaTemperatureHandler(object sender, TemperatureEventArgs args);

        public void NovaTemperatura(int novaTemperatura)
        {
            Console.WriteLine($"Toplomjer: nova temperatura je {novaTemperatura} C");
            if (novaTemperatura != temperatura)
            {
                temperatura = novaTemperatura;
                OnPromjenaTemperature(temperatura);
            }
        }

        protected virtual void OnPromjenaTemperature(int temperatura)
        {
            // ovdje treba generirati događaj PromjenaTemperature
        }

        private int temperatura = 25;
    }

    // Slušatelj koji se mora moći predbilježiti na događaj PromjenaTemperature
    class Grijalica
    {

        private void NaPromjenuTemperature(int temperatura)
        {
            if (temperatura > 21 && Uključena)
            {
                Uključena = false;
                Console.WriteLine($"Grijalica: isključila se jer je temperatura narasla na {temperatura} C");
            }
            else if (temperatura < 19 && !Uključena)
            {
                Uključena = true;
                Console.WriteLine($"Grijalica: uključila se jer je temperatura pala na {temperatura} C");
            }
            else if (Uključena)
                Console.WriteLine($"Grijalica: i dalje uključena na temperaturi {temperatura} C");
            else
                Console.WriteLine($"Grijalica: i dalje isključena na temperaturi {temperatura} C");
        }

        public bool Uključena { get; private set; }
    }
}
