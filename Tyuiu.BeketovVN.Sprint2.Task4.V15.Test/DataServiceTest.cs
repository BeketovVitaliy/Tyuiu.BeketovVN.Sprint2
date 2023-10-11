using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x,y);
            double wait = 12.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -40;
            double y = 0;
            double res = ds.Calculate(x,y);
            double wait = 1.008;
            Assert.AreEqual(wait, res);
        }
    }
}
