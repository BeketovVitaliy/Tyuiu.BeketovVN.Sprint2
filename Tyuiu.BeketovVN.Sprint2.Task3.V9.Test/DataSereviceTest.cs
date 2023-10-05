using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint2.Task3.V9.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataSereviceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataSerevice ds = new DataSerevice();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 23.12;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataSerevice ds = new DataSerevice();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataSerevice ds = new DataSerevice();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.676;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataSerevice ds = new DataSerevice();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -329.967;
            Assert.AreEqual(wait, res);
        }
    }
}
