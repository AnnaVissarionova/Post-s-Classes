using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClasses
{
    internal class MClass
    {

        public static bool Check(int[] eval)
        {
            var res = true;
            if (Array.FindIndex(eval, x => x == 0) == -1)
            {
                return res;
            }
            int index = Array.FindIndex(eval, x => x == 1);
           // Console.WriteLine(index);
            index = index >= 0 ? index : eval.Length;
            for (var i = index; i < eval.Length; i++)
            {
                if (!(CheckSet(eval, i))) {
                    res = false;
                    break;
                }
            }
            return res;
        }

        static bool CheckSet(int[] eval, int num)
        {
            var count =(int) Math.Log2(eval.Length);
            var comparableSets = FindComparableSets(num, count);
            var res = true;
            foreach(var n in comparableSets)
            {
                if (eval[num] > eval[n])
                {
                    res = false;
                    break;
                }
            }
           // Console.WriteLine($"CheckSet {num} : {res}");
          //  Console.WriteLine();
            return res;
        }

        static int[] FindComparableSets(int num, int count)
        {
            var res = new int[0];
            for(var i = num+1; i < (int) Math.Pow(2, count); i++)
            {
                if (AreComparable(num, i, count))
                {
                    res = res.Append(i).ToArray();
                }
            }
            //Console.WriteLine($"FindComparableSets {num} :");
            /*foreach (var e in res)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();*/
            return res;
        }
        static bool AreComparable(int num1, int num2, int count)
        {
            var n1 = ToBinary(num1, count);
            var n2 = ToBinary(num2, count);
            var res = true;
            for (var i  =0; i < n1.Length; i++)
            {
                if (n1[i] > n2[i])
                {
                    res = false;
                    break;
                }
            }
            //Console.WriteLine($"AreComparable {num1} and {num2} : {res}");
            //Console.WriteLine();
            return res;
        }



        /// <summary>
        /// Функция, представляющая заданное число в двоичной СИ ( в виде массива цифр 1 и 0)
        /// </summary>
        /// <param name="num"> число, которое необходимо представить в двоичной системе </param>
        /// <param name="count"> количество разрядов для представления </param>
        /// 
        static int[] ToBinary(int num, int count)
        {
            Debug.Assert((num >= 0) && (count > 0) && (num < (int)Math.Pow(2, count)));
            var i = 0;
            int[] res = FillZero(count);
            while (num > 0)
            {
                res[count - i - 1] = num % 2;
                i++;
                num = num / 2;
            }

            return res;
        }

        /// <summary>
        /// Функция, заполняющая массив нулями
        /// </summary>
        /// <param name="count"> размер массива </param>
        /// 
        static int[] FillZero(int count)
        {
            Debug.Assert(count > 0);
            var res = new int[count];
            for (var i = 0; i < count; i++)
            {
                res[i] = 0;
            }
            return res;
        }
    }
}
