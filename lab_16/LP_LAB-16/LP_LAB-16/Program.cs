using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace LP_LAB_16
{
    class Program
    {
        static async void Main(string[] args)
        {
            try
            {
                //Parallel.For(1, 10, Factorial);
                //Console.ReadLine();

                 MyTPL.Exercise_1();
                Console.WriteLine("================================================\n");
               MyTPL.Exercise_2();
                Console.WriteLine("================================================\n");
               await MyTPL.Exercise_3_4();
                Console.WriteLine("================================================\n");
                MyTPL.Exercise_5();
                Console.WriteLine("================================================\n");
                MyTPL.Exercise_6();
                Console.WriteLine("================================================\n");
                MyTPL.Exercise_7.TaskMain();


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine(ex.Message);
                Console.ResetColor(); // сбрасываем в стандартный
            }
        }
        //static void Factorial(int x)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= x; i++)
        //    {
        //        result *= i;
        //    }
        //    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
        //    Console.WriteLine($"Факториал числа {x} равен {result}");
        //    Thread.Sleep(1000);
        //}
    }
}
