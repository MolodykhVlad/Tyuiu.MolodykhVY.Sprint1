using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task2.V21.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 4;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(12, res);
        }
    }
}
