using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a == b) | (a != c);
            result[1] = (a == b) & (b != d);
            result[2] = (c >= a) || (b < c);
            result[3] = (b >= c) && (a <= c);
            result[4] = !(b != d);
            result[5] = (b < d) ^ (a == b);

            return result;
        }
    }
}
//int a = 185, b = 316, c = 134, d = 134;
//{ true, false, false, false, false, false }