using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.WarmUp
{
    class JumpOnCloudsSolution
    {
        private static List<int> CompletePathLengths;

        // Complete the jumpingOnClouds function below.
        private static int jumpingOnClouds(int[] c)
        {
            CompletePathLengths = new List<int>();
            var rootNode = new Node(0);

            FindSafeNodes(c, rootNode, 0);

            return CompletePathLengths.Min();
        }

        private static void FindSafeNodes(int[] c, Node currentNode, int totalLength)
        {
            if (currentNode.Index + 2 < c.Count() && c[currentNode.Index + 2] == 0)
            {
                UpdateNextHop(currentNode, 2);
            }
            if (currentNode.Index + 1 < c.Count() && c[currentNode.Index + 1] == 0)
            {
                UpdateNextHop(currentNode, 1);
            }
            if (currentNode.Index != c.Count() - 1 && currentNode.SafeNodes.Any())
            {
                foreach (var node in currentNode.SafeNodes)
                    FindSafeNodes(c, node, totalLength + 1);
            }
            else
            {
                CompletePathLengths.Add(totalLength);
            }
        }

        private static void UpdateNextHop(Node currentNode, int distance)
        {
            var next = new Node(currentNode.Index + distance);
            currentNode.SafeNodes.Add(next);
        }

        public static void Run()
        {
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }

    class Node
    {
        public int Index { get; set; }
        public IList<Node> SafeNodes = new List<Node>();

        public Node(int index)
        {
            Index = index;
        }
    }
}
