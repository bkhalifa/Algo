using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public static class MaximumPointsAlgo
    {

        public static int maximumPoints(int k, List<int> costs)
        {
            var sum = 0;
            var counter = 0;
            for (int i = 0; i < costs.Count; i++)
            {
             
                if (sum < k)
                {
                    sum += costs[i];
                 
                    if(sum > k)
                    {
                        sum -= costs[i];
                        counter++;
                      
                    }
                }
                
               
            }
            return k == 1 ? 1 : costs.Count - counter;
        }

    }
}
