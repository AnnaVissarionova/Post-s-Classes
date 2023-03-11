using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClasses
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            var arr = ParseEval("0000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111101001111111111110100111111111111010011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111110000111111111111000011111111111100001111111111111100111111111111110011111111111111001111111111110000111111111111000011111111111100001111111111110000111111111111");
            var blng = new bool[] { PClass.CheckP0(arr), PClass.CheckP1(arr), LClass.Check(arr), SClass.Check(arr), MClass.Check(arr) };
            PrintTable(blng);

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
