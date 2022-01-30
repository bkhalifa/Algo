using System;

namespace Algo
{
    public class NumberOfPairsAlgo
    {
        public static int numberOfPairs(int n)
        {
            int i1 = 5;
            int i2 = 2;
            Console.WriteLine("i" + i1 / i2);
            // Stores the count of pairs
            int count = 0;

            // Set the two pointers
            int i = 1, j = n - 1;

            while (i < j)
            {

                // Check if the sum of
                // pairs is equal to N
                if (i + j == n)
                {

                    // Increase the count
                    // of pairs
                    count++;
                }

                // Move to the next pair
                i++;
                j--;
            }
            return count;
        }
    }
}
