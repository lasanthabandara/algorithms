using Algorithms.HackerRank.WarmUp;
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
            while (true)
            {
                Console.WriteLine("Try Again?");
                RunPrintPatternSolution();
            }
        }

        #region Global
        private static void TreeCuttingAlgoTest()
        {
            var treeCutting = new TreeCuttingAlgo();
            treeCutting.Execute(inputSize: 30000);
        }

        private static void ParallelSpawnTasksTest()
        {
            ParallelSpawnTasks.ParallelForTest();
            ParallelSpawnTasks.TaskTest();
            ParallelSpawnTasks.SpawnTest();
        }

        private static void RunPrintPatternSolution()
        {
            var size = Console.ReadLine();
            PrintPatternSolution.Run(int.Parse(size));
        }
        #endregion

        #region HackerRank

        #region WarmUp
        private static void RunSockMerchant()
        {
            SockMerchantSolution.Run();
        }
        private static void RunValeyCount()
        {
            ValeyCountSolution.Run();
        }
        private static void RunJumpOnCloud()
        {
            JumpOnCloudsSolution.Run();
        }
        private static void RunRepeatedString()
        {
            RepeatedStringSolution.Run();
        }
        #endregion

        #region Arrays
        public void Run()
        {

        }
        #endregion

        #endregion
    }
}
