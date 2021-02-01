using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Vsite.CSharp.Ispit.Zadatak1;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak1 : ConsoleTest
    {
        [TestMethod]
        public void TestIspisaZaMačku()
        {
            var metoda = typeof(Program).GetMethod("AktivirajSe");
            metoda.Invoke(null, new object[] { new Mačka() });

            Assert.AreEqual(2, cw.Length);

            Assert.AreEqual("Krećem se nogama", cw.GetString());
            Assert.AreEqual("Mijau", cw.GetString());
        }

        [TestMethod]
        public void TestIspisaZaPsa()
        {
            var metoda = typeof(Program).GetMethod("AktivirajSe");
            metoda.Invoke(null, new object[] { new Pas() });

            Assert.AreEqual(2, cw.Length);
            Assert.AreEqual("Krećem se nogama", cw.GetString());
            Assert.AreEqual("Vau, vau", cw.GetString());
        }

        [TestMethod]
        public void TestIspisaZaVrapca()
        {
            var metoda = typeof(Program).GetMethod("AktivirajSe");
            metoda.Invoke(null, new object[] { new Vrabac() });

            Assert.AreEqual(2, cw.Length);
            Assert.AreEqual("Letim krilima", cw.GetString());
            Assert.AreEqual("Živ, živ", cw.GetString());
        }

        [TestMethod]
        public void TestIspisaZaVranu()
        {
            var metoda = typeof(Program).GetMethod("AktivirajSe");
            metoda.Invoke(null, new object[] { new Vrana() });

            Assert.AreEqual(2, cw.Length);
            Assert.AreEqual("Letim krilima", cw.GetString());
            Assert.AreEqual("Kra, kra", cw.GetString());
        }

        [TestMethod]
        public void TestIspisa()
        {
            Program.Main();
            Assert.AreEqual(8, cw.Length);

            Assert.AreEqual("Letim krilima", cw.GetString());
            Assert.AreEqual("Kra, kra", cw.GetString());
            Assert.AreEqual("Krećem se nogama", cw.GetString());
            Assert.AreEqual("Mijau", cw.GetString());
            Assert.AreEqual("Letim krilima", cw.GetString());
            Assert.AreEqual("Živ, živ", cw.GetString());
            Assert.AreEqual("Krećem se nogama", cw.GetString());
            Assert.AreEqual("Vau, vau", cw.GetString());
        }
    }
}
