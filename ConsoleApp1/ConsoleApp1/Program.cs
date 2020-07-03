using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        private const string V = "c";

        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Input from console, output to console");
            Console.WriteLine("2) Input from file, otput to file");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    OutputToConsole();
                    break;
                case "2":
                    OutputToFile();
                    break;
                case "3":                    
                    break;
            }
        }

        private static bool IsSupported(string str)
        {
            if (str != "")
            {
                Regex regex = new Regex(@"^(\d*|[IVXLCDMivxlcdm]*)$");
                return regex.IsMatch(str);
            }
            else return false;
        }

        private static bool CheckIsSupported(string str)
        {
            if (IsSupported(str))
                return true;
            else
            {
                Console.WriteLine("Unsupported input.");
                return false;
            }
        }

        private static void OutputToConsole()
        {
            Console.Clear();
            Console.WriteLine("Enter arabian or roman number: ");
            string strInput = Console.ReadLine();

            if (CheckIsSupported(strInput))
            {
                if (int.TryParse(strInput, out int intValue))
                {
                    Console.Write("Roman equivalent: ");
                    Console.WriteLine(Converter.ArabianToRoman(intValue));
                }
                else
                {
                    Console.Write("Arabian equivalent: ");
                    Console.WriteLine(Converter.RomanToArabian(strInput.ToUpper()));
                }
            }
            Console.ReadKey();
        }

        private static void OutputToFile()
        {
            string line;
            StreamReader fileIn = new StreamReader(@"C:\Users\pavloa\source\repos\ConsoleApp1\ConsoleApp1\Input.txt");
            while ((line = fileIn.ReadLine()) != null)
            {
                if (IsSupported(line))
                {
                    if (int.TryParse(line, out int intValue))
                    {
                        using (StreamWriter fileOut = new StreamWriter(@"C:\Users\pavloa\source\repos\ConsoleApp1\ConsoleApp1\Output.txt", true))
                        {
                            fileOut.WriteLine(Converter.ArabianToRoman(intValue));
                            fileOut.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter fileOut = new StreamWriter(@"C:\Users\pavloa\source\repos\ConsoleApp1\ConsoleApp1\Output.txt", true))
                        {
                            fileOut.WriteLine(Converter.RomanToArabian(line.ToUpper()));
                            fileOut.Close();
                        }
                    }
                }
            }
            fileIn.Close();
            Console.WriteLine("Press <Enter> button to finish... ");
            Console.ReadLine();
        }
    }
}
