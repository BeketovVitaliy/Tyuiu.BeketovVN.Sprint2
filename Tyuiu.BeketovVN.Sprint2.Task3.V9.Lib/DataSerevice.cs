using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task3.V9.Lib
{
    public class DataSerevice : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = x * (Math.Pow((x + 15) / (x - 7), x));
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));

                }
                else
                {
                    if ((-13 < x) && (x < 0))
                    {
                        y = Math.Pow((1 + (4 / Math.Pow(x, 2))), x);
                    }
                    else
                    {
                        if (x < -13)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
