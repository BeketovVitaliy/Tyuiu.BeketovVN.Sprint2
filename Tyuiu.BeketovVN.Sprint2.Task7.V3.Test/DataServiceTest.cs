using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint2.Task7.V3.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
