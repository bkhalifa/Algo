

namespace Algo
{
   public class ComputeCheckDigitAlgo
    {
        public static int ComputeCheckDigit(string identificationNumber)
        {
            if (identificationNumber.Length < 1 || identificationNumber.Length > 12)
            {
                return -1;
            }
            var pairs = 0;
            var impairs = 0;
            for (var i = 0; i < identificationNumber.Length; i++)
            {
                //pair
                if (i % 2 == 0)
                {
                    pairs += int.Parse(identificationNumber[i].ToString()) * 3;
                }
                else
                {
                    impairs += int.Parse(identificationNumber[i].ToString());
                }


            }
            var result = pairs + impairs;
            var r = result.ToString();
            int.TryParse(r[r.Length - 1].ToString(), out int res);

            return res != 0 ? (10 - res) : 0;
        }
    }
}
