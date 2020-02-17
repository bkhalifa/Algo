using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public static class DataContext
    {
        public static List<Package> YesterdayPacKage()
        {
            var packs = new List<Package>();
            
            for(var i=1; i<= 5000000; i++)
            {
                packs.Add(new Package { Id = i, Cost= i + 12.25m });

            }
            return packs;

        }

        public static List<Package> ToDayPacKage()
        {
            var packs = new List<Package>();
            for (var i = 1; i <= 5000000 ; i++)
            {
                packs.Add(new Package { Id = i, Cost = i + 12.25m });
            }
            packs.Add(new Package { Id = 1, Cost = 12.25m });
            return packs;
        }
        public static IEnumerable<PackageModel> GetDifferentCosts(List<Package> yesterday, List<Package> today)
        {
            var ret = (from y in yesterday
                       join t in today
                       on y.Id equals t.Id
                       where y.Cost != t.Cost
                       select new PackageModel
                       {
                           Id = y.Id,
                           Varaition = y.Cost - t.Cost

                       });

            return ret?.Any() == true ? ret : null;

        }
    }
    public class PackageModel
    {
        public int Id { get; set; }
        public decimal Varaition { get; set; }
    }
    public class Package
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }

    }



}
