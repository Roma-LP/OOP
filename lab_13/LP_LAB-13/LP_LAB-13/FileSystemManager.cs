using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;


namespace LP_LAB_13
{
    class FileSystemManager
    {
        public void InfoFile(string WayName)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет

            if (!Directory.Exists(Path.GetDirectoryName(WayName)))
                throw new Exception("Нет директории " + Path.GetDirectoryName(WayName));
            if (!File.Exists(WayName))
                throw new Exception("Нет файла " + Path.GetFileName(WayName));

            FileInfo FI = new FileInfo(WayName);
            Console.WriteLine("Дата создания:\t" + FI.CreationTime);
            Console.WriteLine("Дата изменения:\t" + FI.LastWriteTime);
            Console.WriteLine("Имя файла:\t" + FI.Name);

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public void FindDirFile(string Way, string Name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет

            if (!Directory.Exists(Way))
                throw new Exception("Нет директории " + Way);

            string[] files = Directory.GetFiles(Way);
            foreach (string s in files)
            {
                if (Path.GetFileName(s).Contains(Name))
                    Console.WriteLine(Path.Combine(Way, s));
                // else
                //  Console.WriteLine(Path.Combine(Way,s));

            }

            string[] dirs = Directory.GetDirectories(Way);
            foreach (string s in dirs)
            {
                FindDirFile(s, Name);
            }

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public void FindDirFileMask(string Way, Regex Name)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет

            if (!Directory.Exists(Way))
                throw new Exception("Нет директории " + Way);

            string[] files = Directory.GetFiles(Way);
            foreach (string s in files)
            {
                //if(Path.GetFileName(s).Contains(Name))
                // if(Name.Matches(Way))
                if (Name.Matches(s).Count > 0)
                    Console.WriteLine(Path.Combine(Way, s));
                // else
                //  Console.WriteLine(Path.Combine(Way,s));

            }

            string[] dirs = Directory.GetDirectories(Way);
            foreach (string s in dirs)
            {
                FindDirFileMask(s, Name);
            }

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public void InfoDisk()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; // устанавливаем цвет

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название:\t{drive.Name}");
                Console.WriteLine($"Метка тома:\t{drive.VolumeLabel}");
                Console.WriteLine($"Объем диска:\t\t{drive.TotalSize}");
                Console.WriteLine($"Свободное пространство:\t{drive.TotalFreeSpace}");
            }

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public void CreateFolder(string Way, string Name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет

            if (!Directory.Exists(Way))
                throw new Exception("Нет директории " + Way);

            Directory.CreateDirectory(Path.Combine(Way, Name));

            if (Directory.Exists(Path.Combine(Way, Name)))
                Console.WriteLine($"Директория {Name} была успешно создана по пути {Way}");
            else
                throw new Exception($"Не получилось создать директорию {Name} по пути {Way}");

            Directory.Delete(Path.Combine(Way, Name));

            if (!Directory.Exists(Path.Combine(Way, Name)))
                Console.WriteLine($"Директория {Name} была успешна удалена по пути {Way}");
            else
                throw new Exception($"Не получилось удалить директорию {Name} по пути {Way}");

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public void CreateWriteFile(string Way, string Name, string Text, string Mod)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет

            if (!Directory.Exists(Way))
                throw new Exception("Нет директории " + Way);

            switch (Mod)
            {
                case "Create":
                    {
                        using (StreamWriter sw = new StreamWriter(Path.Combine(Way, Name)))
                        {
                            sw.WriteLine(Text);
                        }
                    }
                    break;

                case "Append":
                    {
                        using (StreamWriter sw = new StreamWriter(Path.Combine(Way, Name), true))
                        {
                            sw.WriteLine(Text);
                        }
                    }
                    break;

                case "Exists":
                    {
                        if (File.Exists(Path.Combine(Way, Name)))
                            throw new Exception($"Файл существует " + Path.Combine(Way, Name));

                        using (StreamWriter sw = new StreamWriter(Path.Combine(Way, Name)))
                        {
                            sw.WriteLine(Text);
                        }
                    }
                    break;
                default:
                    throw new Exception("Нет такого режима " + Mod);

            }

            Console.WriteLine("Файл был создан "+ Path.Combine(Way, Name));

            Console.ResetColor(); // сбрасываем в стандартный
        }

        public string ReadFile(string WayName)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет

            if (!Directory.Exists(Path.GetDirectoryName(WayName)))
                throw new Exception("Нет директории " + Path.GetDirectoryName(WayName));
            if (!File.Exists(WayName))
                throw new Exception("Нет файла " + Path.GetFileName(WayName));

            string str;
            using (StreamReader sr = new StreamReader(WayName))
            {
                str = sr.ReadToEnd();
            }

            Console.ResetColor(); // сбрасываем в стандартный

            return str;
        }
    }
}
