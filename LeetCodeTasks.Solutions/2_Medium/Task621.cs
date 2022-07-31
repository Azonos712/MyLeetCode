using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task621 : ILeetCodeTask<int>
    {
        char[] _tasks = { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'E' };
        int _n = 2;

        public int Invoke() => LeastInterval(_tasks, _n);

        public int LeastInterval(char[] tasks, int n)
        {
            int numberOfUnits = 0;
            Dictionary<char, int> count = new Dictionary<char, int>();
            Dictionary<char, int> prior = new Dictionary<char, int>();

            foreach (char task in tasks)
                if (!count.TryAdd(task, 1))
                    count[task]++;

            count = count.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int p = 0;
            foreach (var pair in count)
                prior.Add(pair.Key, p++);

            while (count.Count > 0)
            {
                var pair = prior.MinBy(x => x.Value);

                if (pair.Value <= 0)
                {
                    count[pair.Key]--;
                    prior[pair.Key] += n + 1;

                    if (count[pair.Key] == 0)
                    {
                        count.Remove(pair.Key);
                        prior.Remove(pair.Key);
                    }
                }

                foreach (var item in prior)
                    prior[item.Key] = --prior[item.Key];

                numberOfUnits++;
            }

            return numberOfUnits;
        }
    }
}
