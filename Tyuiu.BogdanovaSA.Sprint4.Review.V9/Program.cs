using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint4.Review.V9.Lib;

namespace Tyuiu.BogdanovaSA.Sprint4.Review.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];

            string str = "864299753";

            Console.Title = "Спринт #4 | Выполнила: Богданова с.а. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Богданова С.А. |     ИСПб-23-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 864299753. Преобразуйте ее            *");
            Console.WriteLine("* в матрицу 3 на 3 и подсчитайте количество четных чисел.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(rows, colums, str);

            Console.WriteLine("Количество четных элементов = " + res);



            Console.ReadKey();
        }
    }
}
        
    
