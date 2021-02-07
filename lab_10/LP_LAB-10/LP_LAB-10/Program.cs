using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(1, 2, 3, "PP");
            Point pt2 = new Point(4, 5, 6, "QQ");
            Point pt3 = new Point();
            Point pt4 = new Point();
            pt1.DisplayInfo();
            pt2.DisplayInfo();
            pt3.DisplayInfo();
            pt4.DisplayInfo();

            Dictionary<int, Point> TablPoint = new Dictionary<int, Point>();
            TablPoint.Add(pt1.GetHashCode(), pt1);
            TablPoint.Add(pt2.GetHashCode(), pt2);
            TablPoint.Add(pt3.GetHashCode(), pt3);
            TablPoint.Add(pt4.GetHashCode(), pt4);

            foreach (KeyValuePair<int, Point> KV in TablPoint)
            {
                Console.WriteLine($"Key:\t{KV.Key} - {KV.Value.Name} ({KV.Value.X},{KV.Value.Y},{KV.Value.Z}) ");
            }
        }
    }
}
