using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task5.V5.Lib;


namespace Tyuiu.MolodykhVY.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int res = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}
