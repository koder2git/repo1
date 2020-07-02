using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public partial class Converter : Component
    {
        static readonly int[] arabian = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static readonly string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static void ArabianToRoman(int input)
        {
            int i = 0;
            string str = "";
            while (input > 0)
            {
                if (arabian[i] <= input)
                {
                    input -= arabian[i];
                    str += roman[i];
                }
                else i++;
            }
            Console.Write("Roman number: ");
            Console.WriteLine(str);
        }

        public static void RomanToArabian(string input)
        {
            int value = 0;
            while (input.Length > 0)
            {
                foreach (var symb in roman)
                {
                    if (symb.Length > input.Length) continue;
                    string sub = input.Substring(0, symb.Length);
                    if (sub == symb)
                    {
                        value += arabian[Array.IndexOf(roman, symb)];
                        input = input.Substring(symb.Length);
                    }
                }
            }
            Console.Write("Arabian number: ");
            Console.WriteLine(value);
        }
    }
}
