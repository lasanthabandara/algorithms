using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Find
{
    class IceCreamParlor
    {
        public static void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int money = Convert.ToInt32(Console.ReadLine().Trim());

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> cost = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(costTemp => Convert.ToInt32(costTemp)).ToList();

                IceCreamParlor.whatFlavors(cost, money);
            }
        }

        public static void whatFlavors(List<int> cost, int money)
        {
            var size = cost.Count;
            for (int i = 0; i < size - 1; i++)
            {
                for(int j = 1 + i; j < size - 1; j++)
                {
                    if (money == cost[i] + cost[j])
                    {
                        Console.WriteLine(++i + " " + (++j));
                        break;
                    }
                }
            }
        }
    }
}
