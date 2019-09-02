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
            var mArray = new long[n];
            long max = 0;
            long rowNumber = 0;
            for (var nRow = 0; nRow < queries.GetLength(0); nRow++)
            {
                for (var i = queries[nRow][0]; i <= queries[nRow][1]; i++)
                {
                    mArray[i - 1] += queries[nRow][2];
                    if (mArray[i - 1] > max) max = mArray[i - 1];
                }
            }

            //for (var el = 0; el < queries.Length; el++)
            //{
            //    if (el % 3 == 0)
            //    {
            //        for (var i = queries[rowNumber][0]; i <= queries[rowNumber][1]; i++)
            //        {
            //            mArray[i - 1] += queries[rowNumber][2];
            //            if (mArray[i - 1] > max) max = mArray[i - 1];
            //        }
            //        rowNumber++;
            //    }
            //}

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
