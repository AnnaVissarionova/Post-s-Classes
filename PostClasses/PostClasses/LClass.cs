using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PostClasses
{
    public class LClass
    {
        /*
         * Главная функция, проверяет, является ли заданная eval'ом функция линейной
         */
        public static bool Check(int[] eval)
        {
            Debug.Assert((int) Math.Ceiling(Math.Log2(eval.Length)) == (int) Math.Floor(Math.Log2(eval.Length))); 
            var count = (int) Math.Log2(eval.Length);
            int[] coef = new int[count + 1];
            coef[0] = eval[0];
            for(var i = 1; i <= count; i++)
            {
                coef[count - i + 1] = coef[0] ^ eval[(int) Math.Pow(2, i-1)];
            }
            Console.WriteLine("Coeff : ");
            foreach (var e in coef)
            {
                Console.Write(e);
            }
            Console.WriteLine();

            return ArrEquals(FindEval(coef, count), eval);
    
        }

     
        /*
         * Функция, находящая eval по заданному массиву коэффициентов a0, a1 ... am и количеству переменных m
         */
        static int[] FindEval(int[] coef, int count) 
        {
            var num = 0;
            var i = 0;
            int[] res = new int[(int) Math.Pow(2, count)];
            while (num < (int) Math.Pow(2, count))
            {
                var binNum = ToBinary(num, count);
                res[i] = coef[0];
                for(var j = 1; j <= count; j++)
                {
                    res[i] = res[i] ^ (coef[j] * binNum[j-1]);
                }
                i++;
                num++;
            }
            Console.WriteLine("FindEval : ");
            foreach(var e in res)
            {
                Console.Write(e);
            }
            Console.WriteLine();
            return res;
        }


        /*
         * Функция, представляющая заданное число в двоичной СИ ( в виде массива цифр 1 и 0)
         */

        static int[] ToBinary(int num, int count)
        {
            var i = 0;
            int[] res = FillZero(count);
            while (num > 0)
            {
                res[count - i -1] = num % 2;
                i++;
                num = num / 2;
            }
            Console.WriteLine($"ToBinary {num} : ");
            foreach (var e in res)
            {
                Console.Write(e);
            }
            Console.WriteLine();
            return res;
            

        }

        /*
        * Функция, заполняющая массив нулями
        */
        static int[] FillZero(int count)
        {
            var res = new int[count];
            for (var i = 0; i < count; i++)
            {
                res[i] = 0;
            }
            return res;
        }

        /*
        * Функция, проверяющая массивы на равенство
        */
        static bool ArrEquals(int[] a, int[] b)
        {
            var res = true;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
