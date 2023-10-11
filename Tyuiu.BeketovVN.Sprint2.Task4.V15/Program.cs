using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BeketovVN.Sprint2.Task4.V15
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил Бекетов В.Н. | ИИПб-23-2                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение использованием *");
            Console.WriteLine("* тернарного оператора где пользователь вводит значение переменных X, Y с *");
            Console.WriteLine("* клвиатуры, если                         2                    12         *");
            Console.WriteLine("* sqrt(x) + 2 > sqrt(y) - 20, то z = (3+ ---)^2 иначе Cos(y)+ (---)       *");
            Console.WriteLine("*                                        x^2                   x^2        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение = " + res);

            Console.ReadKey();
        }
    }
}
