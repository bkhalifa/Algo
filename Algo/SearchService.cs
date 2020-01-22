using System;


namespace Algo
{
   public class SearchService
    {
        public virtual int GetIndexLinearSearchNumber(int[] arr, int x)
        {
            if (arr.Length <= 0)
                throw new ArgumentOutOfRangeException();

            int index = -1;
            if (arr.Length > 0)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == x)
                        index = i;
                }
            }

            return index;
        }
        public virtual int GetIndexValueBinarySearch(int[] arr, int x)
        {
            if (arr.Length <= 0)
                throw new IndexOutOfRangeException();

            var startIndex = (arr.Length + 1)/2;
            
            while (startIndex < arr.Length  && startIndex > -1)
            {
                if (arr[startIndex] == x) 
                    return startIndex;

                if (startIndex == arr.Length -1)
                    startIndex = -1;

                startIndex ++;
            }

            return startIndex;
        }
    }
}
