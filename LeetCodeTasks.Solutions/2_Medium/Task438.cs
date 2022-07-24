using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task438 : ILeetCodeTask<IList<int>>
    {
        string _s = "cbaebabacd";
        string _p = "abc";

        public IList<int> Invoke() => FindAnagrams(_s, _p);

        public IList<int> FindAnagrams(string s, string p)
        {
            if (p.Length > s.Length)
                return new List<int>();

            IList<int> indexes = new List<int>();
            Dictionary<char, int> pDict = StrToDict(p);
            Dictionary<char, int> subDict = StrToDict(s.Substring(0, p.Length));

            if (CompareDict(subDict, pDict))
                indexes.Add(0);

            for (int i = 0; i < s.Length - p.Length; i++)
            {
                if (subDict[s[i]] > 1)
                    subDict[s[i]]--;
                else
                    subDict.Remove(s[i]);

                if (!subDict.TryAdd(s[i + p.Length], 1))
                    subDict[s[i + p.Length]]++;

                bool subRes = CompareDict(subDict, pDict);

                if (subRes)
                    indexes.Add(i + 1);
            }

            return indexes;
        }

        private Dictionary<char, int> StrToDict(string str) => str.Distinct().ToDictionary(x => x, y => str.Count(c => c == y));

        private bool CompareDict(Dictionary<char, int> left, Dictionary<char, int> right)
        {
            return left.All(pair =>
            {
                if (right.TryGetValue(pair.Key, out int value))
                {
                    if (value == pair.Value)
                        return true;
                }
                return false;
            });
        }
    }
}
