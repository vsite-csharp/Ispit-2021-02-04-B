using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Vsite.CSharp.Ispit.Zadatak2;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak2
    {
        [TestMethod]
        public void TestModula()
        {
            var svojstva = typeof(KompleksniBroj).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var svojstvoModul = svojstva.FirstOrDefault(s => s.Name == "Modul" && s.CanWrite == false);
            Assert.IsNotNull(svojstvoModul);

            Assert.AreEqual(Math.Sqrt(2), (double)svojstvoModul.GetValue(new KompleksniBroj(1, 1)));
            Assert.AreEqual(3, (double)svojstvoModul.GetValue(new KompleksniBroj(3, 0)));
            Assert.AreEqual(2, (double)svojstvoModul.GetValue(new KompleksniBroj(0, 2)));
        }

        [TestMethod]
        public void TestArgumenta()
        {
            var svojstva = typeof(KompleksniBroj).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var svojstvoArgument = svojstva.FirstOrDefault(s => s.Name == "Argument" && s.CanWrite == false);
            Assert.IsNotNull(svojstvoArgument);

            Assert.AreEqual(Math.PI / 4, (double)svojstvoArgument.GetValue(new KompleksniBroj(1, 1)));
            Assert.AreEqual(0, (double)svojstvoArgument.GetValue(new KompleksniBroj(3, 0)));
            Assert.AreEqual(Math.PI / 2, (double)svojstvoArgument.GetValue(new KompleksniBroj(0, 2)));
        }

        [TestMethod]
        public void TestOperatoraZbrajanja()
        {
            var statičkeMetode = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var operatorZbrajanja = statičkeMetode.FirstOrDefault(m => m.Name == "op_Addition");
            Assert.IsNotNull(operatorZbrajanja);

            var rezultat = (KompleksniBroj)operatorZbrajanja.Invoke(null, new object[] { new KompleksniBroj(1, 1), new KompleksniBroj(5, 4) });
            Assert.AreEqual(6, rezultat.RealniDio);
            Assert.AreEqual(5, rezultat.ImaginarniDio);

            rezultat = (KompleksniBroj)operatorZbrajanja.Invoke(null, new object[] { new KompleksniBroj(-1, 1), new KompleksniBroj(5, -4) });
            Assert.AreEqual(4, rezultat.RealniDio);
            Assert.AreEqual(-3, rezultat.ImaginarniDio);
        }

        [TestMethod]
        public void TestOperatoraOduzimanja()
        {
            var statičkeMetode = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var operatorOduzimanja = statičkeMetode.FirstOrDefault(m => m.Name == "op_Subtraction");
            Assert.IsNotNull(operatorOduzimanja);

            var rezultat = (KompleksniBroj)operatorOduzimanja.Invoke(null, new object[] { new KompleksniBroj(1, 1), new KompleksniBroj(5, 4) });
            Assert.AreEqual(-4, rezultat.RealniDio);
            Assert.AreEqual(-3, rezultat.ImaginarniDio);

            rezultat = (KompleksniBroj)operatorOduzimanja.Invoke(null, new object[] { new KompleksniBroj(-1, 1), new KompleksniBroj(-5, -4) });
            Assert.AreEqual(4, rezultat.RealniDio);
            Assert.AreEqual(5, rezultat.ImaginarniDio);
        }

        [TestMethod]
        public void TestOperatoraMnoženja()
        {
            var statičkeMetode = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var operatorZbrajanja = statičkeMetode.FirstOrDefault(m => m.Name == "op_Addition");
            Assert.IsNotNull(operatorZbrajanja);

            var rezultat = (KompleksniBroj)operatorZbrajanja.Invoke(null, new object[] { new KompleksniBroj(1, 1), new KompleksniBroj(5, 4) });
            Assert.AreEqual(6, rezultat.RealniDio);
            Assert.AreEqual(5, rezultat.ImaginarniDio);

            rezultat = (KompleksniBroj)operatorZbrajanja.Invoke(null, new object[] { new KompleksniBroj(-1, 1), new KompleksniBroj(5, -4) });
            Assert.AreEqual(4, rezultat.RealniDio);
            Assert.AreEqual(-3, rezultat.ImaginarniDio);
        }

        [TestMethod]
        public void TestUnarnogMinusa()
        {
            var statičkeMetode = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var unarniMinus = statičkeMetode.FirstOrDefault(m => m.Name == "op_UnaryNegation");
            Assert.IsNotNull(unarniMinus);

            var rezultat = (KompleksniBroj)unarniMinus.Invoke(null, new object[] { new KompleksniBroj(5, 4) });
            Assert.AreEqual(-5, rezultat.RealniDio);
            Assert.AreEqual(-4, rezultat.ImaginarniDio);

            rezultat = (KompleksniBroj)unarniMinus.Invoke(null, new object[] { new KompleksniBroj(-1, -7) });
            Assert.AreEqual(1, rezultat.RealniDio);
            Assert.AreEqual(7, rezultat.ImaginarniDio);
        }

        [TestMethod]
        public void TestOperatoraKonjugacije()
        {
            var statičkeMetode = typeof(KompleksniBroj).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            var komplement = statičkeMetode.FirstOrDefault(m => m.Name == "op_OnesComplement");
            Assert.IsNotNull(komplement);

            var rezultat = (KompleksniBroj)komplement.Invoke(null, new object[] { new KompleksniBroj(5, 4) });
            Assert.AreEqual(5, rezultat.RealniDio);
            Assert.AreEqual(-4, rezultat.ImaginarniDio);

            rezultat = (KompleksniBroj)komplement.Invoke(null, new object[] { new KompleksniBroj(-1, -7) });
            Assert.AreEqual(-1, rezultat.RealniDio);
            Assert.AreEqual(7, rezultat.ImaginarniDio);
        }
    }
}
