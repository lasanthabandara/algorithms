using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.WarmUp
{
    class RepeatedStringSolution
    {
        // Complete the repeatedString function below.
        private static long repeatedString(string s, long n)
        {
            var aCountInStringPortion = 0;
            foreach (var letter in s)
            {
                if (letter.Equals('a')) aCountInStringPortion++;
            }

            var fullRepeatCount = Math.Floor((decimal)(n / s.Length)); //How many times you should repeat the string
            var remainingLength = s.Length - n % s.Length; //part of the string that you need to complete the requested length

            var halfACount = 0; //'a' Count in the small part of the string that is required to complete the length 
            for (var i = 0; i < s.Length - remainingLength && remainingLength > 0; i++)
            {
                if (s[i].Equals('a')) halfACount++;
            }

            long result = (long)(aCountInStringPortion * fullRepeatCount + halfACount);
            return result;
        }

        public static void Run()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}
