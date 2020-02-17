namespace ConsoleApp
{
    using System.Linq;
    using System.Collections.Generic;

    class Solution
    {

        public static int FindNetworkEndpoint(int startNodeId, int[] fromIds, int[] toIds)
        {

            if (toIds.Length <= 0 || toIds.Length > 10000)
            {
                return 0;
            }
            List<int> toIdsList = toIds.ToList();
            List<int> fromIdsList = fromIds.ToList();
            bool endFound = false;
            bool lapEnded = false;
            bool startSearch = true;

            int node = startNodeId;
            int indexNode = int.MinValue;
            int oldIndex = int.MinValue;
            while (!endFound && !lapEnded)
            {

                if (!startSearch && (node == startNodeId))
                {
                    lapEnded = true;
                    indexNode = oldIndex;
                    break;
                }
                if (startSearch)
                {
                    startSearch = false;
                }

                if (fromIdsList.Contains(node))
                {
                    oldIndex = indexNode;
                    indexNode = fromIdsList.IndexOf(node);
                    node = toIdsList[indexNode];
                }
                else
                {
                    endFound = true;
                }

            }

            return indexNode;

        }

        /* Ignore and do not change the code below */
        #region
        //static void Main(string[] args)
        //{
        //    string[] inputs;
        //    int startNodeId = int.Parse(Console.ReadLine());
        //    int n = int.Parse(Console.ReadLine());
        //    int[] fromIds = new int[n];
        //    inputs = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < n; i++)
        //    {
        //        fromIds[i] = int.Parse(inputs[i]);
        //    }
        //    int[] toIds = new int[n];
        //    inputs = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < n; i++)
        //    {
        //        toIds[i] = int.Parse(inputs[i]);
        //    }
        //    var stdtoutWriter = Console.Out;
        //    Console.SetOut(Console.Error);
        //    int endPointId = FindNetworkEndpoint(startNodeId, fromIds, toIds);
        //    Console.SetOut(stdtoutWriter);
        //    Console.WriteLine(endPointId);
        //}
        #endregion
    }
}
