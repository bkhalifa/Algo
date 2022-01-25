using System;
using System.Collections.Generic;

namespace Algo
{
    public class FizzBuzzAlgo
    {
        public string[] FizzBuzz(int n)
        {
            string[] ret = new string[100];
            for(var i=1; i<= n; i++)
            {
                if (i % 3 == 0)
                {
                    ret[i]="Fizz"
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

    }
}