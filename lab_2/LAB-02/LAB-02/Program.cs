using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Введите string name: ");
            name = Console.ReadLine();
            int age;
            Console.Write("Введите short age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"name: {name}  age: {age}");        //интерполяция строк
            Console.WriteLine("name: {0}  age: {1}",name,age);     //обычный вывод


            int a = 123;
            long b = a;         // implicit (неявное) conversion from int to long
            int c = (int)b;     // explicit (явное) conversion from long to int


            short shrt = 13;
            Object oVar = shrt;           // boxing
            short shrt2 = (short)oVar;    // unboxing
            int x = 5;
            Object o = x; // Упаковка x 
            byte m = (byte)(int)o; // Распаковка, а затем приведение типа


            var int_var = 5;  // неявно типизированной переменной.
            var str_var = "primer str var";
            Console.WriteLine($"{int_var} , {str_var}");


            int? nullable = null;
            if (nullable.HasValue)
                Console.WriteLine(nullable.Value);
            else
                Console.WriteLine("nullable is equal to null");


            string str1 = "Сторка один два три";
            string str2 = "Cетыре пять шесть семьwedwed";
            Console.WriteLine("\n" + str1 + "\n" + str2);
            int aa = string.Compare(str1, str2); // место в сортировке
            Console.WriteLine("Compare: " + aa);
            bool con = str1.Contains("н д"); //есть ли вхождение строки
            Console.WriteLine(con ? "Yes" : "No");
            string d = str1.Substring(4); //извлекает из строки, есть перегрузки
            Console.WriteLine(d);
            string bb = str1.Insert(3, "(вствляем это в 3 поз)"); //вставляет в строку с позиции
            Console.WriteLine(b);
            string f = str1.Replace("т", "(замен)"); // меняет символы // перегрузка: есть для строк и для символов
            Console.WriteLine(f);
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine($"Длина строки \"Привет мир\": {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            string gg = null;
            bool bo = string.IsNullOrEmpty(gg);// Значение true, равен null или пустой строке ("");
                                               // в противном случае — значение false.

            Console.WriteLine(" unchecked / checked ");
            // Используем unchecked в одном выражении
           // short a_ch = unchecked(short.MaxValue + 100);


            int[] A = new int[10];
            string[] B = new string[10];
            int[] C = { 34, 56, 2, 4 };
            int[] D = new int[] { 3, 5, 67, 4 };
            int[] E = new int[4] { 3, 5, 67, 4 };
            int[,] A1; //элементов нет
            int[,,] B1 = new int[2, 3,4]; // элементы равны 0
            int[,] C1 = { { 1, 2, 3 }, { 4, 5, 6 } }; //new подразумевается
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            int[][] nums = new int[3][];  // зубчатый массив
            nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива
            ValueTuple<string, int> student = ("Olga", 19);  // tuple литералы
            (string, string, int) namesAndAge = ("Olga", "Krol", 22);
            Console.WriteLine(student.GetType().Name);
            Console.WriteLine(namesAndAge.GetType().Name);
            Console.WriteLine($" {student}");
            Console.WriteLine($" {namesAndAge}");
            var myTuple = Corteg(25, "Alexandr");
            Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: "
                + "{2}\nПервый символ в имени: {3}\n", myTuple.Item3,
                myTuple.Item1, myTuple.Item2, myTuple.Item4);

            // Локальные функции
            Console.WriteLine("Сумма чисел до 10: ");
            Console.WriteLine(getSum(10));

        }

        // Данный метод возвращает кортеж с 4-мя разными значениями
        static Tuple<int, float, string, char> Corteg(int a, string name)
        {
            int sqr = a * a;
            float sqrt = (float)(Math.Sqrt(a));
            string s = "Привет, " + name;
            char ch = (char)(name[0]);

            return Tuple.Create<int, float, string, char>(sqr, sqrt, s, ch);
        }

        static int getSum(int x)
        {
            return LocFunc();

            int LocFunc()
            {
                int sum = 0;
                for (int i = 1; i <= x; i++)
                    sum += i;
                return sum;
            }
        }
    }
}
