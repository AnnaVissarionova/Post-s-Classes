using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClasses
{
    public class SClass
    {
        /// <summary>
        /// Главная функция, проверяет, является ли заданная eval'ом функция самодвойственной
        /// </summary>
        /// <param name="eval">Eval заданной функции</param>
        /// <returns></returns>
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

        /// <summary>
        /// Функция отрицания для целочисленного типа
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int NotOper(int n)
        {
            return n == 0 ? 1 : 0;
        }
    }
}
