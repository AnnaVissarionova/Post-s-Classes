using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClasses
{
    public class PClass
    {
        /*
       * Функция, проверяет, является ли заданная eval'ом сохраняющей ноль
       */
        public static bool CheckP0(int[] eval) {
            return eval[0] == 0;
        }

        /*
       * Функция, проверяет, является ли заданная eval'ом сохраняющей единицу
       */
        public static bool CheckP1(int[] eval)
        {
            return eval[eval.Length - 1] == 1;
        }
    }
}
