using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TreeCuttingAlgo
    {
        private int _progressCheck=1000;

        public void Execute(int inputSize)
        {
            var input = new int[inputSize];
            for (int i = 0; i < inputSize; i++)
            {
                input[i] = i + 1;
            }

            _progressCheck = inputSize / 10;

            ExecuteNormal(input);
            Console.WriteLine("\n\n\n");
            ExecuteParallel(input);

            Console.ReadKey();
        }

        private void ExecuteNormal(int[] input)
        {
            Console.WriteLine("Start Normal");
            var watch = new Stopwatch();
            watch.Start();

            var solution = Solution(input);

            watch.Stop();

            Console.WriteLine("Execution Time Normal : " + watch.Elapsed.TotalSeconds);

            Console.WriteLine();
            Console.WriteLine("Answer : " + solution);
        }

        private void ExecuteParallel(int[] input)
        {
            Console.WriteLine("Start Parallel");
            var watch = new Stopwatch();
            watch.Start();

            var solution = SolutionParallel(input);

            watch.Stop();

            Console.WriteLine("Execution Time Parallel : " + watch.Elapsed.TotalSeconds);

            Console.WriteLine();
            Console.WriteLine("Answer : " + solution);
        }

        private int Solution(int[] treesHights)
        {
            var count = 0;
            for (int i = 0; i < treesHights.Length; i++)
            {
                var treesAfterCutting = new int[treesHights.Length - 1];
                var noIssue = true;
                for (var j = 0; j < treesAfterCutting.Length; j++)
                {
                    if (j < i)
                    {
                        treesAfterCutting[j] = treesHights[j];
                    }
                    else
                    {
                        treesAfterCutting[j] = treesHights[j + 1];
                    }
                    if (j > 0 && treesAfterCutting[j - 1] > treesAfterCutting[j])
                    {
                        noIssue = false;
                    }
                }
                if (noIssue)
                {
                    count++;
                }
                if (i % _progressCheck == 0)
                {
                    Console.Write(i / _progressCheck + "  ");
                }
            }
            Console.WriteLine();
            return count;
        }

        private int SolutionParallel(int[] treesHights)
        {
            var results = new List<int>();//new BlockingCollection<int>();
            Parallel.For(0, treesHights.Length, (i) =>
            {
                var treesAfterCutting = new int[treesHights.Length - 1];
                var noIssue = true;
                for (var j = 0; j < treesAfterCutting.Length; j++)
                {
                    if (j < i)
                    {
                        treesAfterCutting[j] = treesHights[j];
                    }
                    else
                    {
                        treesAfterCutting[j] = treesHights[j + 1];
                    }
                    if (j > 0 && treesAfterCutting[j - 1] > treesAfterCutting[j])
                    {
                        noIssue = false;
                    }
                }
                if (noIssue)
                {
                    lock (results)
                    {
                        results.Add(i);
                    }
                }
                if (i % _progressCheck == 0)
                {
                    Console.Write(i / _progressCheck + "  ");
                }
            });
            Console.WriteLine();
            return results.Count;
        }
    }
}
