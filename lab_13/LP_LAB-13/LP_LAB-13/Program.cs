using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LP_LAB_13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var FSM = new FileSystemManager();

                FSM.InfoFile(@"C:\БГТУ\ООТП\lab_12\LP_LAB-12\Infornation.json");

                FSM.FindDirFile(@"C:\БГТУ\ООТП", "Infornation");

                Regex regex = new Regex(@".json(\w*)");
                FSM.FindDirFileMask(@"C:\БГТУ\ООТП", regex);

                FSM.InfoDisk();
                FSM.CreateFolder(@"C:\БГТУ\ООТП", "132");

                string text = "Рандомный те2уцуууу2у2укстesg";
                FSM.CreateWriteFile(@"C:\БГТУ\ООТП", "123.txt", text, "Append");

                string TextFromFile = FSM.ReadFile(@"C:\БГТУ\ООТП\123.txt");
                Console.WriteLine(TextFromFile);
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
