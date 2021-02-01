using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vsite.CSharp.Ispit.Zadatak4;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak4 : ConsoleTest
    {
        [TestMethod]
        public void IspišiSortiranoPoImenu()
        {
            List<Osoba> popisOsoba = new List<Osoba>() {
                new Osoba("Ana", new DateTime(1975, 7, 12)),
                new Osoba("Marko", new DateTime(1983, 4, 2)),
                new Osoba("Tomislav", new DateTime(1971, 11, 5)),
                new Osoba("Luka", new DateTime(1995, 3, 15)),
                new Osoba("Berislav", new DateTime(1965, 12, 3)),
            };

            Program.IspišiSortiranoPoImenu(popisOsoba);
            Assert.AreEqual(5, cw.Length);
            Assert.AreEqual("Ana", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Berislav", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Luka", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Marko", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Tomislav", cw.GetObject<Osoba>().Ime);
        }

        [TestMethod]
        public void IspišiSortiranoPoDatumuRođenja()
        {
            List<Osoba> popisOsoba = new List<Osoba>() {
                new Osoba("Ana", new DateTime(1975, 7, 12)),
                new Osoba("Marko", new DateTime(1983, 4, 2)),
                new Osoba("Tomislav", new DateTime(1971, 11, 5)),
                new Osoba("Luka", new DateTime(1995, 3, 15)),
                new Osoba("Berislav", new DateTime(1965, 12, 3)),
            };

            Program.IspišiSortiranoPoDatumuRođenja(popisOsoba);
            Assert.AreEqual(5, cw.Length);
            Assert.AreEqual("Berislav", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Tomislav", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Ana", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Marko", cw.GetObject<Osoba>().Ime);
            Assert.AreEqual("Luka", cw.GetObject<Osoba>().Ime);
        }
    }
}
