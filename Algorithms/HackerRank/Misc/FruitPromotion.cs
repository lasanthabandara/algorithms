using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Misc
{
    public class FruitPromotion
    {
        public static void Run()
        {
            int codeListCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> codeList = new List<string>();

            for (int i = 0; i < codeListCount; i++)
            {
                string codeListItem = Console.ReadLine();
                codeList.Add(codeListItem);
            }

            int shoppingCartCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> shoppingCart = new List<string>();

            for (int i = 0; i < shoppingCartCount; i++)
            {
                string shoppingCartItem = Console.ReadLine();
                shoppingCart.Add(shoppingCartItem);
            }

            int result = FruitPromotion.foo(codeList, shoppingCart);

            Console.WriteLine(result);
        }

        public static int foo(List<string> codeList, List<string> shoppingCart)
        {
            var easyCodeList = new LinkedList<List<string>>();

            foreach (var line in codeList)
            {
                var words = line.Split(' ');
                var group = new List<string>(words);
                easyCodeList.AddLast(group);
            }

            return bar(easyCodeList, shoppingCart, 0);
        }

        public static int bar(LinkedList<List<string>> easyCodeList, List<string> shoppingCart, int index)
        {
            if (easyCodeList.Any())
            {
                if (shoppingCart.Count > index)
                {
                    var groupToCheck = easyCodeList.First.Value;
                    if (isMatchingWithGroup(groupToCheck, shoppingCart, index))
                    {
                        easyCodeList.RemoveFirst();
                        return bar(easyCodeList, shoppingCart, index + groupToCheck.Count);
                    }
                    else
                    {
                        return bar(easyCodeList, shoppingCart, index + 1);
                    }
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }

        public static bool isMatchingWithGroup(List<string> group, List<string> shoppingCart, int index)
        {
            if ((shoppingCart.Count - index) >= group.Count)
            {
                for (var i = 0; i < group.Count; i++)
                {
                    if (group[i].Equals("anything") || group[i].Equals(shoppingCart[index + i]))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
