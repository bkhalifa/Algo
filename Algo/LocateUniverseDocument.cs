

using System.IO;

namespace Algo
{
   public class LocateUniverseDocument
    {
        public static string LocateUniverseFormula()
        {
            string path = @"C:\temp\Documents";
            string[] filePaths = Directory.GetFiles(path, "*.*",
                                         SearchOption.AllDirectories);

            foreach (var f in filePaths)
            {
                if (f.Contains("universe-formula"))
                {
                    return f;
                }
            }

            return null;
        }
    }
}
