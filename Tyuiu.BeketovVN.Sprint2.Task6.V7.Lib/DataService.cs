using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BeketovVN.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            // Определяем дату 1 января 1990 года
            DateTime startDate = new DateTime(1990, 1, 1);

            // Используем для хранения текущей даты
            DateTime currentDate = startDate;

            // Перебираем месяцы, учитывая разную продолжительность месяцев
            while (n > 0)
            {
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                if (n >= daysInMonth)
                {
                    currentDate = currentDate.AddMonths(1);
                    n -= daysInMonth;
                }
                else
                {
                    currentDate = currentDate.AddDays(n);
                    n = 0;
                }
            }

            string res;
            switch (currentDate.Month)
            {
                case 1:
                    res = "январь"; break;
                case 2:
                    res = "февраль"; break;
                case 3:
                    res = "март"; break;
                case 4:
                    res = "апрель"; break;
                case 5:
                    res = "май"; break;
                case 6:
                    res = "июнь"; break;
                case 7:
                    res = "июль"; break;
                case 8:
                    res = "август"; break;
                case 9:
                    res = "сентябрь"; break;
                case 10:
                    res = "октябрь"; break;
                case 11:
                    res = "ноябрь"; break;
                case 12:
                    res = "декабрь"; break;
                default:
                    res = "Неверный месяц"; break; 
            }
        return res;
        }
    }
}
