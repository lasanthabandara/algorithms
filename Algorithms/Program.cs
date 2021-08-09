using Algorithms.HackerRank.Arrays;
using Algorithms.HackerRank.Dictionaries;
using Algorithms.HackerRank.Find;
using Algorithms.HackerRank.Misc;
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
                RunFruitPromotion();
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

        private static void RunHappyRankSolution()
        {
            //input
            //line 1: happy rank threshold
            //line 2: total count of questions
            //next lines : happy ranks array
            HappyRankSolution.Run();
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
        private static void RunArrayManipulationSolution()
        {
            ArrayManipulationSolution.Run();
        }

        private static void RunHourGlassSolution()
        {
            HourGlasses.Run();
        }
        #endregion

        #region Dictionaries
        private static void RunTwoStrings()
        {
            TwoStrings.Run();
        }
        #endregion

        #region Sort
        private static void RunMarkAndToys()
        {
            TwoStrings.Run();
        }
        #endregion

        #region Find
        private static void RunIceCreamParlor()
        {
            IceCreamParlor.Run();
        }
        #endregion

        #region Misc
        private static void RunWordSuggestions()
        {
            WordSuggestions.Run();
        }
        private static void RunFruitPromotion()
        {
            FruitPromotion.Run();
        }
        #endregion

        #endregion
    }
}
