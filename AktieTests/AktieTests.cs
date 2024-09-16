using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aktie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aktie.Tests
{
    [TestClass()]
    public class AktieTests
    {
        [DataTestMethod]
        [DataRow(1, 20, 30, 10)]
        [DataRow(1, 50, 20, -30)]
        [DataRow(1, 51.54, 22.43, -29.11)]
        [DataRow(1, 30.11, 40.11, 10)]
        [DataRow(5, 30.11, 40.11, 50)]
        [DataRow(5, 60.10, 40.10, -100)]
        [TestMethod()]
        public void AfkastTests(int aktierAntal, double købsKurs, double salgsKurs, double forventet)
        {
            Aktie aktier = new Aktie("aktie", købsKurs, salgsKurs, aktierAntal);
            double actual = aktier.Afkast();
            Assert.AreEqual(forventet, actual, 0.01);
        }
    }
}