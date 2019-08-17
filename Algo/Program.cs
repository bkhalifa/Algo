using System;

namespace Algo
{
    internal class Program
    {
        private static int a, b;

        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Resultat est {z}");
        }

        private static void Main(string[] args)
        {
 
            Console.WriteLine("*************************************************************");

            #region SubArrayWithGivenSum

            int[] array = new int[2] { 1, 4 };
            var sum = 0;

            var SubArray = new SubArrayWithGivenSum().GetSubArrayWithGivenSum(array, sum);
            foreach (var item in SubArray)
            {
                Console.WriteLine(item);
            }

            #endregion SubArrayWithGivenSum

            Console.WriteLine("*************************************************************");

            #region PrimeNumber

            var num = new PrimeNumberService();
            var arr = num.GetPrimeNumbers(20);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            #endregion PrimeNumber

            Console.WriteLine("*************************************************************");

            Console.ReadKey();
        }
    }
}