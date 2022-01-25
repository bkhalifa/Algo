using System;

namespace Algo
{
    public class FizzBuzzAlgo
    {
        public virtual string[] FizzBuzz(int n)
        {
            string[] ret = new string[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    ret[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    ret[i] = "Buzz";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    ret[i] = "Fizz Buzz";
                }
                else
                {
                    ret[i] = i.ToString();
                }
            }
           
            // remove the first element from the array
            string[] newRet = new string[ret.Length -1 ];

            for (var j = 0; j < ret.Length - 1 ; j++)
            {
                newRet[j] = ret[j +1];
            }

             return newRet;
        }
    }
}