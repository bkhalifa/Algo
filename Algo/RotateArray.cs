using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public class RotateArray
    {
        public virtual int[] GetRotateArray(int[] array, int index)
        {
            if (array?.Any() == null ||  index <= 0)
                throw new ArgumentNullException();


            var _result = new List<int>();
            if (index < array.Length)
            {
                for (int i = index; i < array.Length; i++)
                {
                    _result.Add(array[i]);
                }

                for (int j = 0; j < index; j++)
                {
                    _result.Add(array[j]);
                }
            }




            return _result.ToArray();
        }
    }
}