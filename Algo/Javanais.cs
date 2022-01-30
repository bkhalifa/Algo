namespace Algo
{
    public class JavanaisAlgo
    {
        public static string TranslateJavanais(string text)
        {
            var voy = "aeiou";
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < voy.Length; j++)
                {
                    if (text[i].Equals(voy[j]))
                    {
                        result += "av";
                        break;
                    }
                }
                result += text[i];
            }
            return result;
        }
    }
}
