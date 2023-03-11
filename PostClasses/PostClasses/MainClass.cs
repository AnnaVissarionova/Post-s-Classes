using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostClasses
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the eval of function:");
            var inputStr = Console.ReadLine();
            while (!(CheckEval(inputStr)))
            {
                Console.WriteLine();
                Console.WriteLine("Try input again");
                inputStr = Console.ReadLine();
                
            }
            var arr = ParseEval(inputStr);

            //var arr = ParseEval("0000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111101001111111111110100111111111111010011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111111100111111111111110011111111111111001111111111110000111111111111000011111111111100001111111111110000111111111111");
            var blng = new bool[] { PClass.CheckP0(arr), PClass.CheckP1(arr), LClass.Check(arr), SClass.Check(arr), MClass.Check(arr) };
            PrintTable(blng);

        }

        static bool CheckEval(string s)
        {
            Console.WriteLine();
            if ((int) Math.Floor(Math.Log2(s.Length)) != (int)Math.Ceiling(Math.Log2(s.Length)))
            {
                Console.WriteLine("Wrong length of eval.");
                return false;
            }
            if(Regex.IsMatch(s, @"[^01]"))
            {
                Console.WriteLine("Invalid characters.");
                return false;
            }
            if(s.Length > 7)
            {
                Console.WriteLine($"{(int)Math.Log2(s.Length)} params are too much, but i'll do my best (=^..^=) .");
                Console.WriteLine();
            }
            return true;
        }
        static int[] ParseEval(string s)
        {
            var res = new int[s.Length];
            for (var i = 0; i < s.Length; i++)
            {
                res[i] = int.Parse(""+s[i]);
                //Console.Write(s[i]);
            }
            //Console.WriteLine();
            return res;
        }

        static void PrintTable(bool[] blng) 
        {
            var names = new string[] { "P0", "P1", "L", "S", "M" };
            
            Console.WriteLine(String.Format("|{0,12}  |{1,11}  |", "Class name", "Belonging"));
            Console.WriteLine("------------------------------");
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(String.Format("|      {0,-2}      |      {1,1}      |", names[i], blng[i] ? "+" : "-"));
                Console.WriteLine("------------------------------");
            }

        }
    }
}
