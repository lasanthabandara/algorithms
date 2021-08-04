using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Dictionaries
{
    class TwoStrings
    {
        public static void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = TwoStrings.twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }

        private static string twoStrings(string s1, string s2)
        {
            var s1chars = s1.ToCharArray();
            var s2chars = s2.ToCharArray();

            var res = s1chars.Intersect(s2chars);

            if (res.Any()) return "YES";

            //foreach(char c in s1chars)
            //{
            //    if (s2.Contains(c)) return "YES";
            //}

            return "NO";
        }
    }
}
