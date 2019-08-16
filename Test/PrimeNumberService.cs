using System;
using System.Collections.Generic;

namespace Algo
{
    public class PrimeNumberService
    {
        private bool IsPrimeNumber(int? number)
        {
            var isPrime = true;

            if (number < 2)
                isPrime = false;

            if (number % 2 == 0)
                isPrime = false;

            var sqrValue = Math.Floor(Math.Sqrt(number.Value));

            for (int i = 3; i < sqrValue - 1; i += 2)
            {
                if (number % i == 0)
                    isPrime = false;
            }
            return isPrime;
        }

        public virtual IEnumerable<int> GetPrimeNumbers(int? number)
        {
            if (number < 2)
                throw new ArgumentOutOfRangeException();
            if (number == null)
                throw new ArgumentNullException();

            var results = new List<int>();
            while (number > 0)
            {
                if (IsPrimeNumber(number))
                    results.Add(number.Value);
                number--;
            }

            return results;
        }
    }
}