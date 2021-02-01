using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using Vsite.CSharp.Ispit.Zadatak3;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak3 : ConsoleTest
    {
        MethodInfo NađiHandlera(Type tip)
        {
            var metode = tip.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (var metoda in metode)
            {
                var parametri = metoda.GetParameters();
                if (parametri.Length == 2 && parametri[0].ParameterType == typeof(object) && parametri[1].ParameterType == typeof(TemperatureEventArgs))
                {
                    return metoda;
                }
            }
            return null;
        }

        [TestMethod]
        public void ProvjeriJeLiDogađajPromjenaTemperatureDefiniran()
        {
            Assert.IsNotNull(typeof(Toplomjer).GetEvent("PromjenaTemperature"));
        }

        [TestMethod]
        public void ProvjeriJeLiRukovateljUKlasiGrijaliciDefiniran()
        {
            var događaj = typeof(Toplomjer).GetEvent("PromjenaTemperature");
            Assert.IsNotNull(događaj);

            var handler = NađiHandlera(typeof(Grijalica));
            Assert.IsNotNull(handler);
        }

        [TestMethod]
        public void PostaviTemperaturuNa20DaGrijalicaOstaneIsključena()
        {
            var događaj = typeof(Toplomjer).GetEvent("PromjenaTemperature");
            Assert.IsNotNull(događaj);

            var handler = NađiHandlera(typeof(Grijalica));
            Assert.IsNotNull(handler);

            Toplomjer toplomjer = new Toplomjer();
            Grijalica grijalica = new Grijalica();

            Delegate d = Delegate.CreateDelegate(događaj.EventHandlerType, grijalica, handler);
            događaj.AddEventHandler(toplomjer, d);

            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 20 });

            Assert.AreEqual(2, cw.Length);
            Assert.AreEqual("Toplomjer: nova temperatura je 20 C", cw.GetString());
            Assert.AreEqual("Grijalica: i dalje isključena na temperaturi 20 C", cw.GetString());
        }

        [TestMethod]
        public void PostaviTemperaturuNa16DaSeGrijalicaUključi()
        {
            var događaj = typeof(Toplomjer).GetEvent("PromjenaTemperature");
            Assert.IsNotNull(događaj);

            var handler = NađiHandlera(typeof(Grijalica));
            Assert.IsNotNull(handler);

            Toplomjer toplomjer = new Toplomjer();
            Grijalica grijalica = new Grijalica();

            Delegate d = Delegate.CreateDelegate(događaj.EventHandlerType, grijalica, handler);
            događaj.AddEventHandler(toplomjer, d);

            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 16 });

            Assert.AreEqual(2, cw.Length);
            Assert.AreEqual("Toplomjer: nova temperatura je 16 C", cw.GetString());
            Assert.AreEqual("Grijalica: uključila se jer je temperatura pala na 16 C", cw.GetString());
        }

        [TestMethod]
        public void DigniTemperaturuSa16Na22DaSeGrijalicaIsključi()
        {
            var događaj = typeof(Toplomjer).GetEvent("PromjenaTemperature");
            Assert.IsNotNull(događaj);

            var handler = NađiHandlera(typeof(Grijalica));
            Assert.IsNotNull(handler);

            Toplomjer toplomjer = new Toplomjer();
            Grijalica grijalica = new Grijalica();

            Delegate d = Delegate.CreateDelegate(događaj.EventHandlerType, grijalica, handler);
            događaj.AddEventHandler(toplomjer, d);

            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 16 });
            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 22 });

            Assert.AreEqual(4, cw.Length);
            Assert.AreEqual("Toplomjer: nova temperatura je 16 C", cw.GetString());
            Assert.AreEqual("Grijalica: uključila se jer je temperatura pala na 16 C", cw.GetString());
            Assert.AreEqual("Toplomjer: nova temperatura je 22 C", cw.GetString());
            Assert.AreEqual("Grijalica: isključila se jer je temperatura narasla na 22 C", cw.GetString());
        }

        [TestMethod]
        public void DigniTemperaturuSa16Na21DaSeGrijalicaOstaneUključena()
        {
            var događaj = typeof(Toplomjer).GetEvent("PromjenaTemperature");
            Assert.IsNotNull(događaj);

            var handler = NađiHandlera(typeof(Grijalica));
            Assert.IsNotNull(handler);

            Toplomjer toplomjer = new Toplomjer();
            Grijalica grijalica = new Grijalica();

            Delegate d = Delegate.CreateDelegate(događaj.EventHandlerType, grijalica, handler);
            događaj.AddEventHandler(toplomjer, d);

            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 16 });
            typeof(Toplomjer).InvokeMember("NovaTemperatura", BindingFlags.InvokeMethod, null, toplomjer, new object[] { 21 });

            Assert.AreEqual(4, cw.Length);
            Assert.AreEqual("Toplomjer: nova temperatura je 16 C", cw.GetString());
            Assert.AreEqual("Grijalica: uključila se jer je temperatura pala na 16 C", cw.GetString());
            Assert.AreEqual("Toplomjer: nova temperatura je 21 C", cw.GetString());
            Assert.AreEqual("Grijalica: i dalje uključena na temperaturi 21 C", cw.GetString());
        }
    }
}
