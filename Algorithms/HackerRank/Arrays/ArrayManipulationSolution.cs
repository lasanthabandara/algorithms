using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Arrays
{
    class ArrayManipulationSolution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            var mArray = new int[n + 1];
            long max = 0;
            for (var nRow = 0; nRow < queries.GetLength(0); nRow++)
            {
                var a = queries[nRow][0];
                var b = queries[nRow][1];
                var k = queries[nRow][2];
                mArray[a] += k;
                if (b + 1 <= n) mArray[b + 1] -= k;
            }

            var x = max = mArray[0];
            for (var j = 1; j < mArray.Length; j++)
            {
                x += mArray[j];
                if (x > max) max = x;
            }

            return max;
        }

        public static void Run()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
        }
    }
}
