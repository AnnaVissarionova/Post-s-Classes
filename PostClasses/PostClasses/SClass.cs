using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClasses
{
    public class SClass
    {
        /*
        * Главная функция, проверяет, является ли заданная eval'ом функция самодвойственной
        */
        public static bool Check(int[] eval)
        {
            var res = true;
            for (var i = 0; i < eval.Length; i++)
            {
                if (eval[i] != NotOper(eval[eval.Length - i -1]))
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        static int NotOper(int n)
        {
            return n == 0 ? 1 : 0;
        }
    }
}
