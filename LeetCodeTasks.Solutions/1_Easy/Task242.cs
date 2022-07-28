using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task242 : ILeetCodeTask<bool>
    {
        public bool Invoke() => IsAnagram("anagram", "nagaram");

        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
                if (!dic.TryAdd(c, 1))
                    dic[c]++;

            foreach (char c in t)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]--;
                    if (dic[c] == 0)
                        dic.Remove(c);
                }
                else
                {
                    return false;
                }
            }

            return dic.Count == 0;
        }
    }
}
