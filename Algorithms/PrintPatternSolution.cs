using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PrintPatternSolution
    {
        internal static void Run(int k)
        {
            var sList = new List<string>();
            for (var i = 0; i < (2 * k - 1); i++)
            {
                var s = "";
                for (var j = 0; j <= (2 * k - 1 - i); j++)
                {
                    if (j < i)
                    {
                        s += "  ";
                    }
                    else
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                            s += "x ";
                        else if (i % 2 == 0 && j % 2 == 1)
                            s += "  ";
                        else if (i % 2 == 1 && j % 2 == 0)
                            s += "  ";
                        else if (i % 2 == 1 && j % 2 == 1)
                            s += "x ";
                    }
                }
                sList.Add(s);
            }
            for (var i = (1 - k); i <= k - 1; i++)
            {
                Console.WriteLine(sList[Math.Abs(i)]);
            }
        }
    }
}
