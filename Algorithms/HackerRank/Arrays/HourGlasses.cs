using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Arrays
{
    class HourGlasses
    {

        // Complete the arrayManipulation function below.
        static int HourglassSum(int[][] arr)
        {
            var hourGlassSums = new List<int>();
            for (var i = 1; i < 6 - 1; i++)
            {
                for (var j = 1; j < 6 - 1; j++)
                {
                    var sum = arr[i][j] +
                        arr[i + 1][j] +
                        arr[i - 1][j] +
                        arr[i + 1][j + 1] +
                        arr[i + 1][j - 1] +
                        arr[i - 1][j + 1] +
                        arr[i - 1][j - 1];
                    hourGlassSums.Add(sum);
                }
            }
            return hourGlassSums.Max();
        }

        public static void Run()
        {
            int[][] arr = new int[6][];
            for (var i = 0; i < 6; i++)
            {
                arr[i] = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            }

            long result = HourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}
