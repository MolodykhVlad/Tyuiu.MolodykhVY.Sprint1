using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task7.V22.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var wait = 1.129;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
