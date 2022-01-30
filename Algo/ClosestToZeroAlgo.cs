using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class ClosestToZeroAlgo
    {
        public static int ClosestToZero(int[] ints)
        {
            int ret, posmin = int.MaxValue, negmin = int.MinValue;
            if (ints.Length == 0 || ints == null)
            {
                return 0;
            }
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] < 0)
                {
                    if (ints[i] < ints[i + 1])
                    {
                        negmin = ints[i];
                    }
                }
                if (ints[i] > 0)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        posmin = ints[i];
                    }
                }
            }
            ret = posmin;
            if (posmin + negmin == 0)
            {
                ret = posmin;
            }
            return ret;
        }
    }
}
