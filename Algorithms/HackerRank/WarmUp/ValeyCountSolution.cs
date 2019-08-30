using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.WarmUp
{
    class ValeyCountSolution
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            var result = 0;

            var stack = new Stack<char>();
            stack.Push(s.First());
            for (var i = 1; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                    continue;
                }

                char last = stack.Peek();
                var next = s[i];

                if (last.Equals(next))
                {
                    stack.Push(next);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0 & last.Equals('D') & next.Equals('U'))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(0, s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            Console.WriteLine(result);
        }
    }
}
