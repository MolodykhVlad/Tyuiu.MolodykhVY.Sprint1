using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task4.V19.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double result = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(result, res);

        }
    }
}


