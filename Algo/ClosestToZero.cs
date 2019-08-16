using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public class ClosestToZero
    {
        public virtual int? ClosestTo(IEnumerable<int> collection)
        {
            var closest = int.MaxValue;
            var min = int.MaxValue;
            if (collection?.Any() != null)
            {
                foreach (var x in collection)
                {
                    var difference = Math.Abs((long)x);

                    if (min > difference)
                    {
                        min = (int)difference;
                        closest = x;
                    }
                }
                return closest;
            }
            return null;
        }

        public virtual int? ClosestLinqTo(IEnumerable<int> collection)
        {
            if (collection?.Any() != null)
                return collection.OrderBy(x => (long)Math.Abs(x)).First();

            return null;
        }
    }
}