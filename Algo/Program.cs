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
            var sarr = new int[] { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            var sut = new SearchService().GetIndexValueBinarySearch(sarr, 5);

            Console.WriteLine($"sut is {sut}");

            Console.WriteLine("**********sut***************************************************");

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