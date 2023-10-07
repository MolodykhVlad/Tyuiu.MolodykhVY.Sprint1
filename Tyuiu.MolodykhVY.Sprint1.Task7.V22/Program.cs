using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint1.Task7.V22.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Молодых В. Ю. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                            *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                  *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #22                                                                          *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу,                                                                  *");
            Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных,             *");
            Console.WriteLine("* вводимых пользователем. Ответ округлить до 3 знаков после запятой.                   *");
          
            Console.WriteLine("* z =  (1 - tan x)^ctg + cos(x - y)                                                                   *");
            
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");



            Console.WriteLine("Введите знвчени X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знвчени Y:");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
