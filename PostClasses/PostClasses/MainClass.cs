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
            var arr = ParseEval("1100");
            
            Console.WriteLine(LClass.Check(arr));
            Console.WriteLine(SClass.Check(arr));
            Console.WriteLine(PClass.CheckP0(arr));
            Console.WriteLine(PClass.CheckP1(arr));

        }

        static int[] ParseEval(string s)
        {
            var res = new int[s.Length];
            for (var i = 0; i < s.Length; i++)
            {
                res[i] = int.Parse(""+s[i]);
                Console.Write(s[i]);
            }
            Console.WriteLine();
            return res;
        }
    }
}
