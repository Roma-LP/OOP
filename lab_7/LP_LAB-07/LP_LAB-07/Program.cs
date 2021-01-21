using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LP_LAB_07
{
    class Program
    {
        enum Slovesno
        {
            Ras=1,
            Dvas,
            Tris,
            Chetirers,
            Desyatis=10,
            Odinatiris
        }

        static void Main(string[] args)
        {
            Slovesno sl;
            sl = Slovesno.Ras;
            Console.WriteLine(sl+" : "+(int)sl);
            int expl = 10;
            sl = (Slovesno)expl;
            Console.WriteLine(sl.GetType().Name+"."+sl.ToString().ToUpper());
            Console.WriteLine(sl+" : "+(int)sl);
            WriteEnum(Slovesno.Ras);
            WriteEnum(Slovesno.Dvas);
            WriteEnum(Slovesno.Odinatiris);
            Console.WriteLine("----------------------------------------------------------");

            int FiltrEx = 5;
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException   вне диапазона допустимых значений

                object obj = "you";
                int num = (int)obj;     // InvalidCastException   недопустимые преобразования типов
                Console.WriteLine($"Результат: {num}");

                int x = 5;
                int y = x / 0;  // DivideByZeroException  делении на ноль
                Console.WriteLine($"Результат: {y}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Возникло исключение InvalidCastException");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            catch (DivideByZeroException ex) when (FiltrEx != 5)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение ");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; // устанавливаем цвет
                Console.WriteLine("Блок finaly");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            Console.WriteLine("----------------------------------------------------------");

            try
            {
                int xx = 5;
                int yy = 4;
                Debug.Assert(xx == yy,"Они не равны","eerere");


                CollectionController CL = new CollectionController("Va");
                Toy t1 = new Toy(30, "Машинка", 6);
                CL.Add(t1);
                Cake c1 = new Cake(2400, "Наполеон", 58);
                CL.Add(c1);
                Strawberry s1 = new Strawberry(25, "Большая клубника", 100);
                CL.Add(s1);
                NotTovar er = new NotTovar();
                //CL.Add(er);
                CL.Print();
                Console.WriteLine("Количесвто:\t" + CL.Count());

                CL.DeleteLast();
                CL.Print();
                Console.WriteLine("Количесвто:\t" + CL.Count());
                CL.DeleteLast();
                CL.Print();
                Console.WriteLine("Количесвто:\t" + CL.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение Main");
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; // устанавливаем цвет
                Console.WriteLine("Блок finaly");
                Console.ResetColor(); // сбрасываем в стандартный
            }
           // CollectionController CL2 = new CollectionController();
           // CL2 =CL.FindAll();
        }

        static void WriteEnum (Slovesno sl)
        {
            switch (sl)
            {
                case Slovesno.Ras:
                    {
                        Console.WriteLine($"Вывели первое {Slovesno.Ras} и его номер {(int)Slovesno.Ras}");
                    } break;
                case Slovesno.Dvas:
                    {
                        Console.WriteLine($"Вывели второе {Slovesno.Dvas} и его номер {(int)Slovesno.Dvas}");
                    } break;
                case Slovesno.Tris:
                    {
                        Console.WriteLine($"Вывели третье {Slovesno.Tris} и его номер {(int)Slovesno.Tris}");
                    } break;
                case Slovesno.Chetirers:
                    {
                        Console.WriteLine($"Вывели четвертое {Slovesno.Chetirers} и его номер {(int)Slovesno.Chetirers}");
                    } break;
                case Slovesno.Desyatis:
                    {
                        Console.WriteLine($"Вывели десятое {Slovesno.Desyatis} и его номер {(int)Slovesno.Desyatis}");
                    } break;
                case Slovesno.Odinatiris:
                    {
                        Console.WriteLine($"Вывели одинадцатое {Slovesno.Odinatiris} и его номер {(int)Slovesno.Odinatiris}");
                    } break;
                default:
                    break;
            }
        }
    }
}
