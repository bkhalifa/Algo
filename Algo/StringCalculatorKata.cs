
using System.Collections.Generic;

namespace Algo
{
   public static class StringCalculatorKata
    {
        public static int Add(string numbers)
        {
            List<int> costs = new List<int>();
            var s = costs.Count;
            var res = 0;
            if(numbers.Length == 0)
            {
                return res ;
            }

            string negNumbers= string.Empty;

            for (int i = 0; i  < numbers.Length; i++)
            {
                if (numbers[i].ToString().Equals("-"))
                {
                    negNumbers += $"{numbers[i]} {numbers[i + 1]}" ;
                }

                else if (!numbers[i].ToString().Equals(",") &&
                    !numbers[i].ToString().Equals("\n")) {
                  
                    res += int.Parse(numbers[i].ToString());
      
                }
            }
            if (negNumbers.Length > 0)
            {
                throw new System.Exception($"negatives not allowed {negNumbers}");
            }
            
            return res;
        }
    }
}
