using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class NotDividedNumbersAlgo
    {
        public static int[] NotDividedNumbers(int[] diveded, int[] list)
        {
            string res = "";
            for (var i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < diveded.Length; j++)
                {
                    if (list[i] % diveded[j] != 0)
                    {
                        res += list[i + 1];
                        break;
                    }
                }
            }

            return list;
        }
    }
}
