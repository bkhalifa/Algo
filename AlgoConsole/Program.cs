

using Algo;

using System;

namespace AlgoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzAlgo();
            var ret = fizzBuzz.FizzBuzz(7);

            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }
          

            Console.ReadLine();
        }
    }
}
