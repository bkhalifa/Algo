using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public partial class Cost 
    {
        public int Id { get; set; }
        public decimal CostTrip { get; set; }

        
    }


    public  class Variation : IComparable<Cost>
    { 
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            var cost = obj as Cost;
            if (cost != null)
                return this.CompareTo(cost);
            else
                throw new ArgumentException("object is not a cost");


        }

        public int CompareTo(Cost other)
        {
            throw new NotImplementedException();
        }
    }
}
