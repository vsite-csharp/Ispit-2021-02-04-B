using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vsite.CSharp.Ispit.Zadatak5;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak5 : ConsoleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IzračunajRedakBacaIznimkuZaRedakSamoSJednimBrojem()
        {
            Program.IzračunajRedak("1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IzračunajRedakBacaIznimkuZaRedakSamoSJednimBrojemIOperacijom()
        {
            Program.IzračunajRedak("1 -");
        }

        [TestMethod]
        public void IzračunajRedakIspisujeDijeljnjeNulomAkoJeDjeljiteljNula()
        {
            Program.IzračunajRedak("1 / 0");
            Assert.AreEqual("Dijeljenje nulom", cw.GetString());
        }

        [TestMethod]
        public void IzračunajRedakIspisujeBrojčaniPreljevZaPrevelikiRezultat()
        {
            Program.IzračunajRedak(int.MaxValue.ToString() + " * 2");
            Assert.AreEqual("Brojčani preljev", cw.GetString());
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void IzračunajBacaIznimkuZaNepodržanuOperaciju()
        {
            Program.Izračunaj(1, 2, "^");
        }

        [TestMethod]
        public void MetodaMainProlaziKrozSveRetke()
        {
            Program.Main();
            Assert.AreEqual(10, cw.Length);
            Assert.AreEqual("1 + 4 = 5", cw.GetString());
            Assert.AreEqual("5 * 4 = 20", cw.GetString());
            Assert.AreEqual("-3 * 2 = -6", cw.GetString());
            Assert.AreEqual("-6 / -2 = 3", cw.GetString());
            Assert.AreEqual("Neispravan izraz", cw.GetString());
            Assert.AreEqual("Neispravan izraz", cw.GetString());
            Assert.AreEqual("Dijeljenje nulom", cw.GetString());
            Assert.AreEqual("Brojčani preljev", cw.GetString());
            Assert.AreEqual("Operacija ^ nije podržana", cw.GetString());
            Assert.AreEqual("3 - 5 = -2", cw.GetString());
        }
    }
}
