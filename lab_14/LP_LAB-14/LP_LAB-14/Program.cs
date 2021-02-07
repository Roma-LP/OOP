using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
//using System.Runtime.Serialization.Json;
//using System.Text.Json.Serialization;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace LP_LAB_14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point pt1 = new Point(1, 2, 3, "PP");
                Point pt2 = new Point(4, 5, 6, "QQ");
                Point pt3 = new Point(7, 9, 2, "RR");
                Point[] ArrayPoint = new Point[] { pt1, pt2, pt3 };

                string path = @"C:\БГТУ\ООТП\lab_14\LP_LAB-14";


                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(Path.Combine(path, "bin.dat"), FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, ArrayPoint);
                    Console.WriteLine("Binary Serialization");
                }
                using (FileStream fileStream = new FileStream(Path.Combine(path, "bin.dat"), FileMode.Open))
                {
                    Point[] ArrayPoint2 = (Point[])binaryFormatter.Deserialize(fileStream);
                    foreach (Point pt in ArrayPoint2)
                        pt.DisplayInfo();
                    Console.WriteLine("Binary Deserialization");
                }


                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Point));
                using (FileStream fileStream = new FileStream(Path.Combine(path, "xml.xml"), FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fileStream, pt2);
                    Console.WriteLine("Xml Serialization");
                }
                using (FileStream fileStream = new FileStream(Path.Combine(path, "xml.xml"), FileMode.Open))
                {
                    Point ppoint = (Point)xmlSerializer.Deserialize(fileStream);
                    ppoint.DisplayInfo();
                    Console.WriteLine("Xml Deserialization");
                }


                using (StreamWriter sw = File.CreateText(Path.Combine(path, "json.json")))
                {
                    sw.Write(JsonConvert.SerializeObject(pt1, Newtonsoft.Json.Formatting.Indented));
                    Console.WriteLine("Json Serialization");
                }
                var obj = JsonConvert.DeserializeObject<Point>(File.ReadAllText(Path.Combine(path, "json.json")));
                obj.DisplayInfo();
                Console.WriteLine("Json Deserialization");


                XDocument xdoc = XDocument.Load(Path.Combine(path, "exp.xml"));
                var items = from xe in xdoc.Element("ArrayOfPoint").Elements("Point")
                            where xe.Element("X").Value=="5"
                            select new Point
                            {
                                X = Convert.ToInt32(xe.Element("X").Value),
                                Y = Convert.ToInt32(xe.Element("Y").Value),
                                Z = Convert.ToInt32(xe.Element("Z").Value),
                                Name = xe.Element("Name").Value
                            };

                foreach (var item in items)
                    item.DisplayInfo();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine(ex.Message);
                Console.ResetColor(); // сбрасываем в стандартный
            }

        }
    }
}
