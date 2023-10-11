using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Sqrt(x)+2>Math.Sqrt(y)-20) ? (Math.Pow(3+(2/Math.Pow(y,2)),x)) : Math.Cos(y)+(12/Math.Pow(x,2));
            return Math.Round(z, 3);
        }
    }
}
