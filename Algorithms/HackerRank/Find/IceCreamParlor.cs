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

        private static void whatFlavors(List<int> cost, int money)
        {
            var size = cost.Count;
            var map = new Dictionary<int, int>();
            for (int i = 0; i < size; i++)
            {
                if (map.ContainsKey(cost[i]))
                {
                    map[cost[i]]++;
                }
                else { map[cost[i]] = 1; }
            }
            for (int i = 0; i < size; i++)
            {
                var v1 = cost[i];
                var v2 = money - cost[i];
                if (v1 != v2)
                {
                    if (map.ContainsKey(v2) && map[v1] != 0 && map[v2] != 0)
                    {
                        Print(cost.IndexOf(v1), cost.IndexOf(v2));
                        break;
                    }
                }
                else
                {
                    if (map[v1] > 1)
                    {
                        var index1 = cost.IndexOf(v1);
                        var index2 = cost.IndexOf(v1, index1 + 1);
                        Print(index1, index2);
                        break;
                    }
                }
            }
        }

        private static void Print(int v1, int v2)
        {
            if (v2 > v1)
            {
                Console.WriteLine(++v1 + " " + (++v2));
            }
            else
            {
                Console.WriteLine(++v2 + " " + (++v1));
            }
        }
    }
}
