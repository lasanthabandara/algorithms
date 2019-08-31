using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class HappyRankSolution
    {
        public static int minNum(int threshold, List<int> happy)
        {
            var questionCount = happy.Count;

            for (var i = happy.Count - 1; i >= 0; i--)
            {
                for (var j = 0; j < happy.Count; j++)
                {
                    if ((happy[i] - happy[j]) >= threshold && (i - j + 1) < questionCount)
                    {
                        questionCount = i - j + 1;
                    }
                }
            }
            return (int)Math.Floor((decimal)questionCount / 2) + 1;
        }

        public static void Run()
        {
            int threshold = Convert.ToInt32(Console.ReadLine().Trim());

            int happyCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> happy = new List<int>();

            for (int i = 0; i < happyCount; i++)
            {
                int happyItem = Convert.ToInt32(Console.ReadLine().Trim());
                happy.Add(happyItem);
            }

            int result = minNum(threshold, happy);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
