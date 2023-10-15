using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint2.Task5.V4.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2| Выполнил: Бекетов В.Н. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил Бекетов В.Н. | ИИПб-23-2                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики»—1, масти «трефы» — 2, масти «бубны» - 3, масти «червы» — 4 *");
            Console.WriteLine("* По заданному номеру масти m (1 <= m <= 4) определить название           *");
            Console.WriteLine("* соответствующей масти.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты: ");
            int value = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((value < 1) || (value > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это карта " + ds.FindCardSuit(value);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
