using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MolodykhVY.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Молодых В. Ю. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("*  Выполнил: Молодых Владислав Юрьевич | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Введите значение стоимости тетради:                                      *");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            int b;
            Console.WriteLine("*Введите значение количества тетрадей:                                    *");
            b = Convert.ToInt32(Console.ReadLine());
            double c;
            Console.WriteLine("*Введите значение стоимости карандаша:                                    *");
            c = Convert.ToDouble(Console.ReadLine());
            int d;
            Console.WriteLine("*Введите значение количества карандашей:                                  *");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Общая стоимость покупки = " + ds.PurchaseAmount(a, b, c, d));
            Console.ReadLine();
        }
    }
}
