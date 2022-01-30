

using Algo;

using System;
using System.Collections.Generic;

namespace AlgoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumPoints();

            Console.ReadLine();
        }
        static void TestFizzBuzz()
        {
            var fizzBuzz = new FizzBuzzAlgo();
            var ret = fizzBuzz.FizzBuzz(7);

            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }
        }
        static void StringCalculator()
        {
           var ret = StringCalculatorKata.Add("1\n2,-3");
            Console.WriteLine(ret);
        }
        static void MaximumPoints()
        {
            List<int> costs = new List<int> { 10, 5, 5, 2, 3 ,1, 4};  // k= 10  n = 5
            // List<int> costs = new List<int> { 2, 4, 1, 8, 6 }; //4
            int ret = MaximumPointsAlgo.maximumPoints(10, costs);
            Console.WriteLine(ret);
        }
    }
}
