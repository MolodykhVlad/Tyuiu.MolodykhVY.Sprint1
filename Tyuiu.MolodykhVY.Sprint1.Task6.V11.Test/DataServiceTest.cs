using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint1.Task6.V11.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Пиво";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
