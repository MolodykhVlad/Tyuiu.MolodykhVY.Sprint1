using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 5.3453;
            int amountNotebook = 2;
            double pricePencil = 31.5673;
            int amountPencil = 4;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(136.960, res);
        }
    }
}
