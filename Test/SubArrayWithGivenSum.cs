using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public class SubArrayWithGivenSum
    {
        public virtual int[] GetSubArrayWithGivenSum(int[] array, int sum)
        {
            var retArray = new List<int>();
            int sumValue = 0;
            var idx = 0;
            while (idx <= array.Length)
            {
                if (sumValue < sum)
                {
                    sumValue += array[idx];
                    retArray.Add(array[idx]);
                    if (sumValue == sum)
                        return retArray.ToArray();
                }
                else
                {
                    sumValue = 0;
                    var arr = array.ToList();
                    if (arr.Count == 0)
                        break;

                    arr.RemoveAt(0);
                    array = arr.ToArray();
                    retArray.Clear();
                    idx = -1;
                }

                idx++;
            }

            return new int[] { -1 };
        }
    }
}