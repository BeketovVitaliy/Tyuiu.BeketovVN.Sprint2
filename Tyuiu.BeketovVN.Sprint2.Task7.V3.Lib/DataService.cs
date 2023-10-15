using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool condition1 = Math.Pow(x,2) + Math.Pow((y - 1), 2) <= 1;
            bool condition2 = y >= 1 - Math.Pow(x,2);

            bool res;
            if (condition1 && condition2) //((y >= 1 - Math.Pow(x, 2)) && (Math.Pow(x, 2) + Math.Pow(y - 1, 2) <= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
