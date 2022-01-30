

namespace Algo
{
   public class NumberCaracterAlgo
    {
        public static string NumberCaracter()
        {

            string str = "aabaa";
            int counter = 1;
            string result = "";

            for (var i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                {
                    if (str[i] != str[i - 1])
                    {
                        counter = 1;
                    }

                    result += counter.ToString() + str[i];
                    break;
                }

                if (str[i] == str[i + 1])
                {
                    counter++;

                }

                if (str[i] != str[i + 1])
                {
                    result += counter.ToString() + str[i];
                    counter = 1;
                }

            }

            return result;
        }
    }
}
