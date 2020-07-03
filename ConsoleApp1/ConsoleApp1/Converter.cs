using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    class Converter
    {
        static readonly int[] arabian = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static readonly string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string ArabianToRoman(int input)
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
            return str;
        }

        public static int RomanToArabian(string input)
        {
            int value = 0;
            while (input.Length > 0)
            {
                for (int i = 0; i < roman.Length; i++)
                {
                    var symb = roman[i];
                    if (symb.Length > input.Length) continue;
                    if (input.Substring(0, symb.Length) == symb)
                    {
                        value += arabian[i];
                        input = input.Substring(symb.Length);
                        break;
                    }
                }
            }
            return value;
        }
    }
}
