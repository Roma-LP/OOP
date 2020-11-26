using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //string name;
        //Console.Write("Введите name: ");
        //name = Console.ReadLine();
        //short age;
        //Console.Write("Введите name2: ");
        //name = Console.ReadLine();

        //Console.Write("Введите age: ");
        //age = Convert.ToInt16(Console.Read());
        //Console.WriteLine($"Имя: {name}  Возраст: {age}");        //интерполирование строк
        //Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);     //обычный вывод

        short per = 6;
        Object oVar = per;           // boxing
        short per2 = (short)oVar;    // unboxing
        int x = 5;
        Object o = x; // Упаковка x 
        byte m = (byte)(int)o; // Распаковка, а затем приведение типа

        Console.WriteLine("\n\n(string foramt)-----------------------------------------------------");
        String Name = "World";
        byte Age = 45;
        float size = 34.34323f;                            //количество знаков после запятой 
        string exer = String.Format("Имя : {0}\nРазмер : {1:f2}\nВозраст : {2:d8}", Name, size, Age);
        Console.WriteLine(exer);                                              //количество нулей перед числом  

        //object методы
        int xx = 568;
        Console.WriteLine("Тип: " + xx.GetType());
        Console.WriteLine("Хэш-код: " + xx.GetHashCode());
        Console.WriteLine("Строка: " + xx.ToString());




        string str1 = "Сторка один два три";
        string str2 = "Cетыре пять шесть семьwedwed";
        Console.WriteLine("\n" + str1 + "\n" + str2);

        int a = string.Compare(str1, str2); // место в сортировке
        Console.WriteLine("Compare: " + a);
        bool con = str1.Contains("н д"); //есть ли вхождение строки
        Console.WriteLine(con ? "Yes" : "No");
        string d = str1.Substring(4); //извлекает из строки, есть перегрузки
        Console.WriteLine(d);
        String b = str1.Insert(3, "(вствляем это в 3 поз)"); //вставляет в строку с позиции
        Console.WriteLine(b);
        string f = str1.Replace("т", "(замен)"); // меняет символы // перегрузка: есть для строк и для символов
        Console.WriteLine(f);

        string gg=null ;
        bool bo = string.IsNullOrEmpty(gg);// Значение true, равен null или пустой строке ("");
                                           // в противном случае — значение false.
        Console.WriteLine(bo ? "Yes" : "No");
        string gg2 = null;
        bool bo2 = string.IsNullOrEmpty(gg2);
        Console.WriteLine(bo2 ? "Yes" : "No");

        string gg3 = "dada Vasa228";
        bool bo3 = string.IsNullOrEmpty(gg3);
        Console.WriteLine(bo3 ? "Yes" : "No");




        //System.Nullable<int> x = null;
        ////          или так: 
        ////          int count? = null;
        //int y = x ?? 1; // возвращает левый операнд, если он не равен nullable
        //Console.WriteLine(" count стал = " + y);


        Console.WriteLine(" unchecked / checked ");
        short a_ch;
        // Используем unchecked в одном выражении
        a_ch = unchecked((short)(256 + short.MaxValue));




        // null строка
        String StrNull = null;
        String StrNull1 = StrNull;
        String StrNull2 = StrNull;



        // StringBuider()
        StringBuilder stringBuilder = new StringBuilder("Здесь строка, построенная при помощи объекта StringBuilder");
        Console.WriteLine(stringBuilder);
        Console.WriteLine("\t После удаления последнего и первого элемента: ");
        int SbLength = stringBuilder.Length;
        stringBuilder.Remove(SbLength - 1, 1);
        stringBuilder.Remove(0, 1);
        Console.WriteLine(stringBuilder);
        Console.WriteLine("а теперь встатвим в эти же позиции новые символы: ");
        stringBuilder.Insert(SbLength - 2, "#");
        stringBuilder.Insert(0, "#");
        Console.WriteLine(stringBuilder);
        Console.ReadKey();
        Console.WriteLine("------------------------------------------------------");

        int[] A = new int[10];
        string[] B = new string[10];
        int[] C = { 34, 56, 2, 4 };
        int[] D = new int[] { 3, 5, 67, 4 };
        int[] E = new int[4] { 3, 5, 67, 4 };
        int[,] A1; //элементов нет
        int[,] B1 = new int[2, 3]; // элементы равны 0
        int[,] C1 = { { 1, 2, 3 }, { 4, 5, 6 } }; //new подразумевается

        String
        // Локальные функции
        Console.WriteLine("Сумма чисел до 10(включая 10) с помощью локальной функции ");
        Console.WriteLine(getSum(10));



       
        
            var myTuple = Corteg(25, "Alexandr");
            Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: "
                + "{2}\nПервый символ в имени: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);

       Console.ReadKey();
    }

    // Данный метод возвращает кортеж с 4-мя
    // разными значениями
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