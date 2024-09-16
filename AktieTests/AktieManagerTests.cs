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
    public class AktieManagerTests
    {
        //[TestMethod()]
        //public void AddAktieTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        [DataTestMethod]
        [DataRow(50, 40, 65, -1950)]
        [DataRow(100.6, 120.5, 40, 2388)]
        [DataRow(40, 50, 10, 300)]
        public void TotalAfkastTest_3AktieObj(double købKurs, double salgsKurs, int antalAktier, double expected)
        {
            AktieManager.Clear();
            Aktie aktie1 = new Aktie("aktie1", købKurs, salgsKurs, antalAktier);
            Aktie aktie2 = new Aktie("aktie2", købKurs, salgsKurs, antalAktier);
            Aktie aktie3 = new Aktie("aktie3", købKurs, salgsKurs, antalAktier);
            AktieManager.AddAktie(aktie1);
            AktieManager.AddAktie(aktie2);
            AktieManager.AddAktie(aktie3);
            double actual = AktieManager.TotalAfkast();
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}