using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;

namespace LP_LAB_16
{
    class MyTPL
    {
        private static CancellationTokenSource source = new CancellationTokenSource();
        private static CancellationToken token = source.Token;
        private static Stopwatch stopwatch = new Stopwatch();
        private static Random rnd = new Random();

        public static void Exercise_1()
        {
            for (int i = 1; i < 4; i++)
            {
                int color = rnd.Next(1, 15);
                int value = rnd.Next(9999, 999999);
                stopwatch.Start();
                Task task = Task.Factory.StartNew(() =>
                {
                    Eratosfen eratosfen = new Eratosfen(value);
                });
                Console.ForegroundColor = (ConsoleColor)color;// устанавливаем цвет
                Console.WriteLine($"Итерация: {i} Числа: {value} Статус: {task.Status}");
                task.Wait();
                stopwatch.Stop();
                Console.WriteLine($"Время для задания {i}) {stopwatch.Elapsed}\n");
                stopwatch.Reset();
                Console.ResetColor(); // сбрасываем в стандартный
            }
        }

        public static void Exercise_2()
        {
            for (int i = 1; i < 4; i++)
            {
                int color = rnd.Next(1, 15);
                int value = rnd.Next(999, 9999);
                //Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Task task = Task.Factory.StartNew(() =>
                {
                    Eratosfen eratosfen = new Eratosfen(value);
                });
                Console.ForegroundColor = (ConsoleColor)color;// устанавливаем цвет
                Console.WriteLine($"Итерация: {i} Числа: {value} Статус: {task.Status}");

                Console.WriteLine("Нажми клавишу s для завершения процесса");
                if (Console.ReadKey().KeyChar == 's')
                    source.Cancel();

                task.Wait();
                stopwatch.Stop();
                Console.WriteLine($"Время для задания {i}) {stopwatch.Elapsed}\n");
                stopwatch.Reset();
                Console.ResetColor(); // сбрасываем в стандартный
            }
        }

        public static async void Exercise_3_4()
        {
            Task<int> task1 = Task.Factory.StartNew(GetWeight);
            Task<int> task2 = Task.Factory.StartNew(GetDensity);
            Task<int> task3 = Task.Factory.StartNew(GetCapacity);

            await task1.ContinueWith((firstTask) => Console.WriteLine($"Результат первого задания: {firstTask.Result}"));
            await task2.ContinueWith((secondTask) => Console.WriteLine($"Результат второго задания: {secondTask.Result}"));
            await task3.ContinueWith((thirdTask) => Console.WriteLine($"Результат третего задания: {thirdTask.Result}"));

            task3.ContinueWith((thirdTask) => Console.WriteLine($"Результат третего задания с GetAwaiter(): {thirdTask.Result}")).GetAwaiter();
            task2.ContinueWith((secondTask) => Console.WriteLine($"Результат второго задания с GetAwaiter().GetResult(): {secondTask.Result}")).GetAwaiter().GetResult();
        }

        // Methods by formula: m = Vq, where q - density, V - capacity
        const int capacity = 100; // объем
        const int density = 1000; // плотность
        const int weight = 6000;

        public static int GetWeight() => capacity * density;
        public static int GetDensity() => weight / capacity;
        public static int GetCapacity() => weight / density;


        public static void Exercise_5()
        {
            int from = rnd.Next(1, 5);
            int before = rnd.Next(5, 7);
            stopwatch.Start();
            Parallel.For(from, before, Factorial);
            stopwatch.Stop();
            Console.WriteLine($"Числа {from}-{before}  Время с Parallel.For: " + stopwatch.Elapsed);
            stopwatch.Restart();


            stopwatch.Start();
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 91, 41, 20, 13 },Factorial);
            stopwatch.Stop();
            Console.WriteLine("Время для Parallel.ForEach: " + stopwatch.Elapsed);
        }
        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Факториал числа: {x} равен => {result}");
           // Thread.Sleep(3000);
        }


        public static void Exercise_6()
        {
            Parallel.Invoke(Exercise_6_help, Exercise_6_help, Exercise_6_help);
        }
        private static void Exercise_6_help()
        {
            int color = rnd.Next(1, 15);
            int value = rnd.Next(999, 99900);
            stopwatch.Start();
            Eratosfen eratosfen = new Eratosfen(value);
            stopwatch.Stop();
            Console.ForegroundColor = (ConsoleColor)color;// устанавливаем цвет
            Console.WriteLine($"Числа: {value} Время для задания  {stopwatch.Elapsed}  ID: {Task.CurrentId}");
            stopwatch.Reset();
            Console.ResetColor(); // сбрасываем в стандартный
        }


        public class Exercise_7
        {
            private static int productCount;
            private static BlockingCollection<string> products;

            private static void PutProuct()
            {

                int productsToPutCount = 1;


                Console.WriteLine($"Продцедура поместила продукт {productCount} в хранилище");

                products.CompleteAdding();
            }

            private static void TakeProduct()
            {
                string productToTake;
                while (!products.IsCompleted)
                {
                    if (products.TryTake(out productToTake))
                        Console.WriteLine($"Пользователь взял продукт{productToTake} из хранилища");

                }
            }


            private static void ShowWarehouse()
            {
                Console.WriteLine("------------Продукты------------");
                foreach (var product in products)
                    Console.WriteLine(product);
                Console.WriteLine("--------------------------------\n\n");
            }

            public static void TaskMain()
            {
                productCount = 0;
                products = new BlockingCollection<string>();

                Task[] producers = new Task[]
                {
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct)
                };
                Task[] consumers = new Task[]
                {
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct)
                };

                Task.WaitAll(producers.Concat(consumers).ToArray());
                foreach (var pr in producers)
                    pr.Dispose();
                foreach (var con in consumers)
                    con.Dispose();
            }
        }
    }
}
