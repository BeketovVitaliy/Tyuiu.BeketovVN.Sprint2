using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string res;

            switch (value)
            {
                case 1:
                    res = "Пики";
                    break;
                case 2:
                    res = "Трефы";
                    break;
                case 3:
                    res = "Бубны";
                    break;
                case 4:
                    res = "Червы";
                    break;
                default:
                    throw new ArgumentException($"Карта должна быть от 1 до 4. Значение {value}");
            }

            return res;
        }
    }
}
