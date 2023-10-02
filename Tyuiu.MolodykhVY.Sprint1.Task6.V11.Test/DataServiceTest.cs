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
            string strTest = "Ппиво";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
