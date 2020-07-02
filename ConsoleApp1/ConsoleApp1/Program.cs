using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue;

            Console.WriteLine("Enter arabian or roman number: ");
            
            String strInput = Console.ReadLine();
            
            if (CheckIsSupported(strInput)) 
            {
                if (int.TryParse(strInput, out intValue))
                {
                    Converter.ArabianToRoman(intValue);
                }
                else
                {
                    Converter.RomanToArabian(strInput.ToUpper());
                }
            }
            Console.ReadKey();

            static bool IsSupported(string str)
            {
                if (str != "")
                {
                    Regex regex = new Regex(@"^(\d*|[IVXLCDMivxlcdm]*)$");
                    return regex.IsMatch(str);
                }
                else return false;
            }

            static bool CheckIsSupported(string str)
            {
                if (IsSupported(str))
                { return true; }
                else
                {
                    Console.WriteLine("Unsupported input.");
                    return false;
                }
            }
        }
    }
}
