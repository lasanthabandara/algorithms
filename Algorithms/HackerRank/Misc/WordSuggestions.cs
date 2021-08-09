using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Misc
{
    public class WordSuggestions
    {
        public static void Run()
        {
            int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> repository = new List<string>();

            for (int i = 0; i < repositoryCount; i++)
            {
                string repositoryItem = Console.ReadLine();
                repository.Add(repositoryItem);
            }

            string customerQuery = Console.ReadLine();

            List<List<string>> result = WordSuggestions.searchSuggestions(repository, customerQuery);

            Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
        }

        public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
        {
            var output = new List<List<string>>();
            repository.Sort();

            if (customerQuery.Length >= 2)
            {
                for(var i = 2; i <= customerQuery.Length; i++)
                {
                    var query = customerQuery.Substring(0,i);
                    var suggestions = new List<string>();
                    foreach(var item in repository)
                    {
                        if (item.StartsWith(query,StringComparison.InvariantCultureIgnoreCase))
                        {
                            suggestions.Add(item.ToLower());
                            if (suggestions.Count >= 3) break;
                        }
                    }
                    output.Add(suggestions);
                }
            }

            return output;
        }
    }
}
