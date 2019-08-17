
using System;
using System.Collections;
using System.Linq;

namespace Algo
{
    public class FibonacciNumber
    {
        private bool IsFibonacciNumber(int n)
        {
            return (Math.Sqrt(n) * Math.Sqrt(n) == n);
        }


        public virtual int[] GetFibonacciNumber(int[] array)
        {
        
            var _result = new ArrayList();

            if (array?.Any() == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                 if (IsFibonacciNumber (5 * (array[i] * array[i]) + 4) || IsFibonacciNumber(5 * (array[i] * array[i]) - 4))
                     _result.Add(array[i]);
                 

                }

            }

            return _result.ToArray(typeof(int)) as int[];
        }
  
    }
}
