using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_04
{
    class RightTriangle  // Прямоугольный треугольник
    {
        double hypotenuse = 1;
        double cathet_x = 1;
        double cathet_y = 1;
        double perimeter;
        double square;
        int SumOfAngel=180;

        public double Cathet_x
        {
            set
            {
                cathet_x = value;
                PeriemtrSqure();
            }
            get { return cathet_x; }
        }
        public double Cathet_y
        {
            set
            {
                cathet_y = value;
                PeriemtrSqure();
            }
            get { return cathet_y; }
        }
        public double Hypotenuse
        {
            set
            {
                hypotenuse = value;
                PeriemtrSqure();
            }
            get { return hypotenuse; }
        }
        public double Perimeter
        {
            get { return perimeter; }
        }
        public double Square
        {
            get { return square; }
        }
        void PeriemtrSqure()  // для пересчета периметра и площади
        {
            perimeter = hypotenuse + cathet_x + cathet_y;
            square = 0.5 * (cathet_x * cathet_y);
        }

        public RightTriangle()
        {
            PeriemtrSqure();
        }
        public RightTriangle(double cathet_x, double cathet_y, double hypotenuse)
        {
            Hypotenuse = hypotenuse;
            Cathet_x = cathet_x;
            Cathet_y = cathet_y;
            PeriemtrSqure();
        }

        public override string ToString()
        {
            string str1 = "";
            str1 += "Катет_1:\t" + cathet_x + "\n";
            str1 += "Катет_2:\t" + cathet_y + "\n";
            str1 += "Гипотенуза:\t" + hypotenuse + "\n";
            str1 += "Периметр:\t" + Perimeter + "\n";
            str1 += "Площадь:\t" + Square;
            return str1;
        }

        public static bool operator < (RightTriangle RT1, RightTriangle RT2)
        {
            return RT1.perimeter < RT2.perimeter && RT1.square < RT2.square;
        }
        public static bool operator > (RightTriangle RT1, RightTriangle RT2)
        {
            return RT1.perimeter > RT2.perimeter && RT1.square > RT2.square;
        }
        //  explicit (если преобразование явное, то есть нужна операция приведения типов) или implicit (если преобразование неявное)
        public static explicit operator int(RightTriangle rt)
        {
            Console.WriteLine("<явное преобразование>");
            return rt.SumOfAngel;
        }
        public static RightTriangle operator + (RightTriangle RT1, RightTriangle RT2)
        {
            RightTriangle rt = new RightTriangle
            {
                Cathet_x = RT1.Cathet_x + RT2.Cathet_x,
                Cathet_y = RT1.Cathet_y + RT2.Cathet_y,
                Hypotenuse = RT1.Hypotenuse + RT2.Hypotenuse
            };
            return rt;
        }
            

            
    }

    class ListRightTriangles
    {
        //Array list = new RightTriangle[5];
        //RightTriangle[] list= new RightTriangle[5];
        List<RightTriangle> list = new List<RightTriangle>();
        List<Information> info = new List<Information>();

        public void Add(RightTriangle rt)
        {
            ICanDo(rt);
            Add(rt, "Пушкин");
        }
        public void Add(RightTriangle rt, string name)
        {
            ICanDo(rt);
            Information Info = new Information(name);
            list.Add(rt);
            info.Add(Info);
        }
        public void DeleteLast()
        {
            list.RemoveAt(list.Count-1);
            info.RemoveAt(info.Count-1);
        }
        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list.ElementAt(i).ToString());
                info.ElementAt(i).Print();
            }
            
        }
        private void ICanDo(RightTriangle rt)
        {
            if (rt.Cathet_x <= 0)
            {
                Console.WriteLine($"Ошибка ввода, значение Cathet_x не может быть ниже 0: {rt.Cathet_x}?! (установлино значение 1)");
                rt.Cathet_x = 1;
            }
            if(rt.Cathet_y <= 0)
            {
                Console.WriteLine($"Ошибка ввода, значение Cathet_y не может быть ниже 0: {rt.Cathet_y}?! (установлино значение 1)");
                rt.Cathet_y = 1;
            }
            if(rt.Hypotenuse <= 0)
            {
                Console.WriteLine($"Ошибка ввода, значение Hypotenuse не может быть ниже 0: {rt.Hypotenuse}?! (установлино значение 1)");
                rt.Hypotenuse = 1;
            }
        }

        class Information
        {
            DateTime dateTime;
            string author;
            public Information()
            {
            }
            public Information(string name)
            {
                author = name;
                dateTime = DateTime.Now;
                System.Threading.Thread.Sleep(5000);
            }
            public void Print()
            {
                Console.WriteLine("Дата и время: "+dateTime);
                Console.WriteLine("Автор: "+author+"\n");
            }
        }
    }
}
