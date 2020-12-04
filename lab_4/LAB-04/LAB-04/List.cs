using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04
{
    public class List
    {
        List<string> Collect = new List<string>();
        public int count = 0;
        public List(params string[] str)
        {
            for(int i=0;i<str.Length;i++)
            {
                str[i]+=Date.GetData();
                Collect.Add(str[i]);
                count++;
                
            }
        }
        public void Add(string str)
        {
            str += Date.GetData();
            Collect.Add(str);
            count++;
        }
        void Add(string str,bool b)
        {
            Collect.Add(str);
            count++;
        }
        public void Add(List lst)
        {
            for (int i = 0; i < lst.count; i++)
            {
                Add(lst[i],true);
            }
        }
        public void print()
        {
            foreach (string i in Collect)
            {
                Console.WriteLine(i);
            }
        }

        public static List operator +(List lt, string str)  // " + " добавить элемент в начало (item+list) 
        {
            List nwCollect = new List();
            nwCollect.Add(str);
            nwCollect.Add(lt);
            return nwCollect;
        }
        public static List operator --(List lt)  // " -- " удалить первый элемент из списка(--list)
        {
            List nwCollect = new List();
            for (int i = 1; i < lt.count; i++)
            {
                nwCollect.Add(lt[i], true);
            }
            return nwCollect;
        }
        public static bool operator !=(List lt1, List lt2)  //  " != " - проверка на неравенство
        {
            
            return lt1.count!=lt2.count;
        }
        public static bool operator ==(List lt1, List lt2)  //  " == " - обязательная пара
        {

            return lt1.count == lt2.count;
        }
        public static List operator *(List lt1, List lt2)  // " * " - объединение двух списков
        {
            List nwCollect = new List();
            for (int i = 0; i < lt1.count; i++)
            {
                nwCollect.Add(lt1[i],true);
            }
            for (int j = 0; j < lt2.count; j++)
            {
                nwCollect.Add(lt2[j],true);
            }
            return nwCollect;
        }

        public string this[int index]  // индексатор
        {
            get
            {
                return Collect[index];
            }
        }

        public class Owner
        {
            int ID;
            string Name;
            public Owner():this(000,"NoName")
            {

            }
            public Owner(string Name,int ID):this(ID,Name)
            {

            }
            public Owner(int ID,string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
            public void Print()
            {
                Console.WriteLine($"ID: {ID} Name: {Name}");
            }
        }

        static class Date
        { 
            public static string GetData()
            {
                return " : " + DateTime.Now;
            }
        }
    }
}
