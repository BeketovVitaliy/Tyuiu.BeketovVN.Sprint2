using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint2.Task6.V7.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            string monthName1 = ds.FindMonthName(1990, 0);
            string monthName2 = ds.FindMonthName(1990, 30); // Должен вернуть "январь"
            string monthName3 = ds.FindMonthName(1990, 60); // Должен вернуть "февраль"
            string monthName4 = ds.FindMonthName(1991, 80); // Должен вернуть "апрель"
            string monthName5 = ds.FindMonthName(1992, 366); // Должен вернуть "декабрь"

            Assert.AreEqual("январь", monthName1);
            Assert.AreEqual("январь", monthName2);
            Assert.AreEqual("март", monthName3);
            Assert.AreEqual("март", monthName4);
            Assert.AreEqual("январь", monthName5);
        }
    }
}
