using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task409 : ILeetCodeTask<int>
    {
        string s = "abbc";

        public int Invoke()
        {
            return LongestPalindrome(s);
        }

        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            int maxPalindrome = 0;

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    map[c] = map[c] + 1;
                    if (map[c] % 2 == 0)
                    {
                        maxPalindrome += map[c];
                        map[c] = 0;
                    }
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            if (map.ContainsValue(1))
                maxPalindrome++;

            return maxPalindrome;
        }
    }
}
