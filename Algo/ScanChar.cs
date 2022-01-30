using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class ScanCharAlgo
    {
        public static char scanChar(String s)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (AsciiArt.printChar(c) == (s))
                {
                    return c;
                }
            }
            return '?';
        }
        class AsciiArt
        {
            public static String printChar(char s)
            {
                return "S";
            }
        }
    }
}
