using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2
{
    class Program
    {

        static void Main(string[] args)
        {

            int ivar = 5;
            Object oVar = ivar; // boxing
            int ivar2 = (int)oVar;// unboxing


            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            string ex = String.Format("Hello {0}", name); // string foramt
            Console.WriteLine(ex);

            Console.WriteLine("-----------------------------------------------------");
            String MyName = "\nВасюкович Марта Александровна";
            int Age = 17;
            float cource = 2f;
            char gruppe = '8';

            Console.WriteLine(MyName + "\n" + Age + " лет \n" + "ФИТ " + cource + " курс " + gruppe + " группа\n");

            // Неявыне преобразвования
            long NumL = 500;
            double NumD = NumL;
            Console.WriteLine("из long в double " + NumD);
            byte NumB = 4;
            short NumBS = NumB;
            Console.WriteLine("из byte в short " + NumBS);
            float NumF = NumBS;
            Console.WriteLine("из short в float " + NumD);
            NumL = NumB;
            Console.WriteLine("из byte в long " + NumD);
            int NumI = 40;
            NumD = NumI;
            Console.WriteLine("из int в double " + NumD);
            // Явные преобразования
            NumL = (long)NumB;
            NumBS = (short)NumB;
            NumD = (double)NumI;
            NumL = (long)NumI;
            NumI = (int)gruppe;


            string str1 = "sharpu eto mosch";
            string str2 = "soglasen eto da";
            {
                int a = string.Compare(str1, str2); // место в сортировке

                String b = str1.Insert(3, str1); //вставляет в строку с позиции

                bool c = str1.Contains("eto"); //вхождение строки

                string d = str1.Substring(4); //извлекает из строки, есть перегрузки

                string f = str1.Replace("s", "c"); // меняет символы // перегрузка: есть для строк и для символов
            }

            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            String Test(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "пустая";
                else
                    return String.Format("(\"{0}\") не пустая", s);
            }

            int? xyx = null;
            if (xyx.HasValue)
                Console.WriteLine(xyx.Value);
            else
                Console.WriteLine("xyx is null");

            int? xex = 10;
            if (xex.HasValue)
                Console.WriteLine("xex = " + xex.Value);
            else
                Console.WriteLine("xex is null");

            dynamic perem = "fds";
            perem = 5;







            System.Nullable<int> x = null;
            //          или так: 
            //          int count? = null;
            int y = x ?? 1; // возвращает левый операнд, если он не равен nullable
            Console.WriteLine(" count стал = " + y);
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");



            String Str1 = "Апанович Ася";
            String Str2 = "Калганова Аня";
            String Str3 = "Рутковская Катя";

            // Сравнение строк

            //if (Str1 == Str2)
            //    Console.WriteLine("");
            //else
            //    Console.WriteLine("");

            // или так: 
            if (Str1.Equals(Str2))
                Console.WriteLine("Катя и Аня один и тот же человек");
            else
                Console.WriteLine("Катя и Аня НЕ один и тот же чел");

            //Конкатенация строк:

            //String Str12 = Str1 + Str2;
            //Console.WriteLine(Str12);

            // или вот так:
            String StrConcat = "";
            StrConcat = String.Concat(Str1, Str2);
            Console.WriteLine(StrConcat);


            // Копирование строк
            String StrCopy = "";
            StrCopy = String.Copy(Str3);
            Console.WriteLine(Str3);


            // Разделение строки на слова
            String StrSplit = "Я хочу сдать эту лабу";
            byte Count = 0;
            string[] Words = StrSplit.Split(' ');
            foreach (string Word in Words)
            {
                Console.WriteLine(Word);
                Count++;
            }
            Console.WriteLine("\t Всего слов : " + Count);


            // Вставка подстроки 
            String Str123 = " ( надеюсь сдать )";
            Console.WriteLine(StrSplit.Insert(7, Str123));


            // Удаление подстроки
            String StrRemove = "\nЯ не Марта";
            Console.WriteLine(StrRemove);
            Console.WriteLine("\tОЙ!");
            Console.WriteLine("Вот! Теперь так: " + StrRemove.Remove(3, 3));


            // null строка
            String StrNull = null;
            String StrNull1 = StrNull;
            String StrNull2 = StrNull;


            // Дествия с null строкой
            StrNull1 = String.Copy(MyName);
            Console.WriteLine(StrNull1);
            StrNull2 = String.Concat(StrNull2, MyName);


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



            // Двухмерные матрицы
            int[,] matrix = new int[4, 4];
            Random Rnd = new Random();
            Console.WriteLine(matrix.Length);
            for (int count1 = 0; count1 < 4; count1++)
            {
                for (int count2 = 0; count2 < 4; count2++)
                {
                    matrix[count1, count2] = Rnd.Next(-10, 10);
                    Console.Write("\t{0}", matrix[count1, count2]);
                }
                Console.WriteLine();
            }

            // Массив строк и дейстаия над ним
            String[] StrArray = new String[5] { "Марта", "Ася", "Костя", "Степа", "Паша" };
            int StrArrayLength = StrArray.Length;
            Console.WriteLine("Всего слов в массиве: {0}", StrArrayLength);
            Console.Write("Вот наш маccив строк: ");
            for (int i = 0; i < StrArrayLength; i++)
                Console.Write(StrArray[i] + "\t");
            Console.Write("\nВ какую позицию ставим?");
            int toArray = Convert.ToInt32(Console.ReadLine());
            if (toArray > 0 && toArray < StrArrayLength + 1)
            {
                Console.Write("\nKакое слово будем вставлять? \t");
                String NewName = Console.ReadLine();
                StrArray[toArray - 1] = NewName;
                Console.WriteLine("Замена выполнена!!!");
                Console.Write("\tПолучившийся массив:\t");
                for (int i = 0; i < StrArrayLength; i++)
                    Console.Write(StrArray[i] + "\t");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Проверьте номер заменяемого элемента!\n");


            // Работа со ступенчатым массивом
            Console.WriteLine("Работа со ступенчатым массивом: \n Введите элементы в массив: \n");
            int[][] SteppedArray = new int[3][];
            SteppedArray[0] = new int[2];
            SteppedArray[1] = new int[3];
            SteppedArray[2] = new int[4];
            for (int i = 0; i < 3; i++)
            {
                int SteppedArrayLength = SteppedArray[i].Length;
                for (int countA = 0; countA < SteppedArrayLength; countA++)
                {
                    Console.Write("[{0}][{1}] = ", i, countA);
                    SteppedArray[i][countA] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                int SteppedArrayLength = SteppedArray[i].Length;
                for (int countA = 0; countA < SteppedArrayLength; countA++)
                {
                    Console.Write(SteppedArray[i][countA] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Неявно типизированные массив и строка
            var ArrayString = new[] { "Доброе утро", "Good Morning", "Guten Morgen" };
            var ArrayNumbers = new[] { 3, 145, 15, 13, 5, 345, 7, 2, 5, 14, 124, 2 };
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");




            // Кортежи

            String Name = "Владислав";
            var Tuple = Corteg(ArrayNumbers, Name);
            Console.WriteLine("Минимальный элемент: {0}\n Максимальный элемент: {1} \n Сумма: {2} \n Первая буква имени: {3}", Tuple.Item1, Tuple.Item2, Tuple.Item3, Tuple.Item4);

            (int age, string name, char group, string facultat, ulong cource) student = (17, "Marta", '8', "IT", 2);
            Console.WriteLine($"{student}");
            Console.WriteLine($"Студент {student.name}, которому {student.age} лет, учится в {student.group} -ой группе на {student.cource} курсе факультета {student.facultat}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");

            // Локальные функции
            Console.WriteLine("Сумма чисел до 10(включая 10) с помощью локальной функции ");
            Console.WriteLine(getSum(10));
        }


        static Tuple<int, string, char, string, ulong> Corteg1(int num, string str1, char symbol, string str2, ulong unum)
        {
            return Tuple.Create(num, str1, symbol, str2, unum);
        }


        static Tuple<int, int, int, char> Corteg(int[] ArrayNumbers, string Name)
        {
            int max = ArrayNumbers.Max();
            int min = ArrayNumbers.Min();
            int sum = ArrayNumbers.Sum();
            char FirstSymbol;
            FirstSymbol = Name[0];
            return Tuple.Create<int, int, int, char>(min, max, sum, FirstSymbol);
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


ЭТО БЫЛ МОЙ КОД, А ТЕПЕРЬ ВОПРОСЫ ГДЕ ТУТ ЧЕ 

1)	Чем отличается var и dynamic 




2)	 Что это Изучите класс и работу со StringBuilder
3)	Используя интерполирование строк 


4)	Изучите методы класса Object
   //в твоей лабе не описаны эти функции
   // equals, tostring, gettype, hashcode


5)	Ознакомьтесь с возможностями Nullable-типов, это кажись есть у меня в коде
    // эти типы могут принимать нулевое значение, 
  // обычные- нет. строка 84, ex (int? variable=null)

6)	Изучите работу с массивами в.NET
   // честно не разбирался
   // почти тоже самое что и в плюсах




7)	Ознакомьтесь с понятием «локальная функция».
//  это функция в функции, видна только из внешней функции




8)	Ознакомьтесь с типом Tuple
    // это из кортежа, тоже не разбирался
    // это вроде не обязательно было



9)	Ознакомьтесь с концепцией «небезопасного кода и указателей» в.NET.Познакомьтесь с ключевыми словами unsafe и fixed
    // в с# можно пользоваться указателями если указать слово unsafe, потому что указатели не безопасны
    // fixed запрещает компилятору, перемещать переменную в памяти

10)	Познакомьтесь с ключевыми словами checked и unchecked.


Практика и вставь пж кусочки кода с минимальными пояснениями
    //это не делал
   // тут гугл марта, сор
1.Определите несколько переменных различных типов.Продемонстрируйте на них операции «упаковки» и «распаковки».
//14- 16 строка

2.Определите переменную типа int со значением, равным вашему номеру в подгруппе.Выполните операции явного и неявного приведения к 3 отличным от int типам.
  



3.Определите переменную типа string со значением, равным вашему имени.Выведите на консоль строку: “My name is < name >”, где вместо < name > -значение переменной, используя: a. string.format; b.интерполирование строк.
    // string format строка 21


4. Продемонстрируйте использование открытых методов класса Object на ваших переменных.


 5. Создайте две переменных типа string. Продемонстрируйте на них работу следующих методов: a.Compare b. Contains c. Substring d. Insert e. Replace
    //57-65

 6. Продемонстрируйте использование метода string.IsNullOrEmpty на примере пустой и null-строк.
    //72-81


7. Определите переменную неопределенного типа и присвойте ей любое значение.Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки
    //96


8. Продемонстрируйте работу с Nullable-переменной.
    //90

1. Определите локальную функцию, принимающую параметром кортеж из 2 элементов int типа. Продемонстрируйте вызов этой функции.
    // c кортежами не разбирался

 2. Создайте кортеж из трех именованных аргументов. Продемонстрируйте различные способы распаковки кортежа.Продемонстрируйте использование переменной (_ ). (доступно начиная с C#7.3) 

3. Работа с checked/unchecked: a.Определите две локальные функции. b.Разместите в одной из них блок checked, в котором определите переменную типа int с максимальным возможным значением этого типа.Во второй функции определите блок unchecked с таким же содержимым. 
   // не делал, почитай просто теорию про них
c.Вызовите две функции.Проанализируйте результат.  

