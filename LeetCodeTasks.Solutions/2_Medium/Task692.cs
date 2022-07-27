using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task692 : ILeetCodeTask<IList<string>>
    {
        public IList<string> Invoke() => TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 3);

        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var word in words)
                if (!map.TryAdd(word, 1))
                    map[word]++;

            var result = map
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(y => y.Key)
                .Take(k)
                .ToList();

            return result;
        }
    }
}
