using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Threading;


namespace LP_LAB_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TimerCallback timercallback = new TimerCallback(Time);  //создается объект делегата TimerCallback
                Timer timer = new Timer(timercallback, null, 0, 8000); // создаем таймер

                var process = Process.GetProcesses();
                foreach (var pr in process)
                {
                    Console.Write("Proc ID: " + pr.Id);
                    Console.Write("\tName: " + pr.ProcessName);
                    Console.Write("\t\tПриоритет: " + pr.BasePriority);
                    //Console.Write("\t\tВремя : " + pr.StartTime.ToLongTimeString());
                    Console.WriteLine("\t\tЧисло потоклв: " + pr.Threads.Count);
                }
                Console.WriteLine("Количесвто процессов:\t" + process.Count());
                Console.WriteLine();

                Process calc = Process.Start(@"C:\БГТУ\ООТП\lab_12\LP_LAB-12\LP_LAB-12\bin\Debug\LP_LAB-12.exe");
                Thread.Sleep(1000);
               // calc.Kill();
                //calc.CloseMainWindow();

                AppDomain domain = AppDomain.CurrentDomain;//домен приложения
                Console.WriteLine("Имя домена:\t" + domain.FriendlyName);
                var assembls = domain.GetAssemblies();
                Console.WriteLine("Сборки домена:\t" + assembls);
                foreach (var i in assembls)
                {
                    Console.WriteLine(i.GetName().Name);
                }
                Console.WriteLine("Детали конфигурации:\t" + domain.SetupInformation.ConfigurationFile);  // имя детали конфигурации


                AppDomain newD = AppDomain.CreateDomain("New");
                Console.WriteLine("Имя домена:\t" + newD.FriendlyName);
                newD.Load(assembls[3].GetName());

                Thread thread = new Thread((object s ) => { });
                thread.Priority = ThreadPriority.Lowest;//Свойство Priority хранит приоритет потока - значение перечисления ThreadPriority
                Console.Write("Введите N: ");
                int N = int.Parse(Console.ReadLine());
                Console.Write("Введите имя потока: ");
                thread.Name = Console.ReadLine();
                thread.Start(N);//метод старт запускает поток


                Thread threadEven = new Thread(new ParameterizedThreadStart(EvenNumber));
                Thread threadOdd = new Thread(new ParameterizedThreadStart(OddNumber));
                threadEven.Priority = ThreadPriority.Highest;//Свойство Priority хранит приоритет потока - значение перечисления ThreadPriority
                threadOdd.Priority = ThreadPriority.BelowNormal;//Свойство Priority хранит приоритет потока - значение перечисления ThreadPriority
                Console.Write("Введите N для Even: ");
                int N_even = int.Parse(Console.ReadLine());
                Console.Write("Введите имя потока для Even : ");
                threadEven.Name = Console.ReadLine();
                Console.Write("Введите N для Odd: ");
                int N_odd = int.Parse(Console.ReadLine());
                Console.Write("Введите имя потока для Odd : ");
                threadOdd.Name = Console.ReadLine();
                threadEven.Start(N_even);//метод старт запускает поток
                threadOdd.Start(N_odd);//метод старт запускает поток
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine(ex.Message);
                Console.ResetColor(); // сбрасываем в стандартный
            }
        }

        public static void Number(object N)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
            Thread t = Thread.CurrentThread;//вовзвр выполняющий в данный момент поток

            for (int i = 1; i <= (int)N; i++)
            {
                Console.WriteLine($"{i}) Имя потока: {t.Name}  Выполняется: {t.IsAlive}  Приоритет: {t.Priority}");
                Thread.Sleep(300);//приост поток
            }
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void EvenNumber(object N)
        {
            Thread t = Thread.CurrentThread;//вовзвр выполняющий в данный момент поток

            for (int i = 1; i <= (int)N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет
                    Console.WriteLine($"{i}) Имя потока: {t.Name}  Выполняется: {t.IsAlive}  Приоритет: {t.Priority}");
                }
                Thread.Sleep(800);//приост поток
            }
            Console.ResetColor(); // сбрасываем в стандартный
        }
        public static void OddNumber(object N)
        {
            Thread t = Thread.CurrentThread;//вовзвр выполняющий в данный момент поток

            for (int i = 1; i <= (int)N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                    Console.WriteLine($"{i}) Имя потока: {t.Name}  Выполняется: {t.IsAlive}  Приоритет: {t.Priority}");
                }
                Thread.Sleep(300);//приост поток
            }
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Time(object x)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет
            Console.WriteLine("Работа класса Timer");
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
