using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_2
{
    partial class GameIndusrty
    {
        String GameName;
        public int point;
        char role;
        readonly int T;
        static GameIndusrty() { // статический коснтруктор
            Console.WriteLine("static");

        }
        public GameIndusrty() { Console.WriteLine("non-static"); }
        public GameIndusrty(string GameName, int point, char role) {
            this.role = role;
            this.GameName = GameName;
            this.point = point;
        }
        public GameIndusrty(GameIndusrty gameindusrty) {
            this.point = gameindusrty.point;
            this.role = gameindusrty.role;
            this.GameName = gameindusrty.GameName;
        }
        int sum;
        // readonly 

        public int Sum
        {
            get { return sum; }
            set
            {
                if (value > 0)
                {
                    sum = value;
                }
            }
        }
        public override string ToString()
        {
            return GameName + point;
        }
    
        ~GameIndusrty()
        {
            Console.WriteLine("delete GameIndusrty");
        }
        // 
        public void refparametr(ref int r, out int j)
        {
            r++;
            j = 5;
        }
        public static string anyTime() {
            return "static method";
        }
        //var Gamein= new { Name = "Tom", point = 34 };
    }

    partial class GameIndusrty
    {
        public override int GetHashCode()
        {
            return point * role;
        }
        public override bool Equals(object obj)
        {
            GameIndusrty gamename = (GameIndusrty)obj;

            return (this == gamename);
        }
    }
    public class maina
    {
        static void Main(string[] args)
        {
            GameIndusrty.anyTime();
            GameIndusrty game = new GameIndusrty("312", 32, 'c');
            ArrayList arrayList = new ArrayList();
            arrayList.Add(game);
            arrayList.RemoveAt(2);
            int r = arrayList.Count;
            foreach (object o in arrayList)
            {
                GameIndusrty Gare = (GameIndusrty)o;
                if (Gare.point == 3)
                    break;
            }

            Console.WriteLine(arrayList.ToString());
            Console.WriteLine(arrayList.GetType());
            Console.WriteLine(arrayList);
        }
    }
    // ref out
    public class MyList<T> {
        T[] mass;
        int index;
        private static MyList<T> mylist;

        private MyList(T tipe, int size) {
            mass =new T[size];
            index = 0;
        }

        public MyList<T> getInstance(T type) {
            if (mylist == null)
                mylist= new MyList<T>(type, 100);
            return mylist;
        }
        bool MyAdd(T value) {
              if (!value.ToString().Contains("Object"))
            {
            mass[index] = value;
            index++;
                return true;
            }
            return false;
        }
        

        void myDel() {
            
            if (index > 0) {
                index--;
            }
        }

        public T get(int k) {
            return mass[k];
        }
        public int Ccoint()
        {
            return mass.Length;
        }

        public override string ToString()
        {
            return mass.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        public override int GetHashCode()
        {
            return mass.Count();
        }
    }
    public static class Share
    {
        
    }   
}

