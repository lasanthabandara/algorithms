using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main");
            Console.ReadKey();
        }

        private void TreeCuttingAlgoTest()
        {
            var treeCutting = new TreeCuttingAlgo();
            treeCutting.Execute(inputSize: 30000);
        }

        private void ParallelSpawnTasksTest()
        {
            ParallelSpawnTasks.ParallelForTest();
            ParallelSpawnTasks.TaskTest();
            ParallelSpawnTasks.SpawnTest();
        }
    }
}
