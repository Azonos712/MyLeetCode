using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task3 : ILeetCodeTask<int>
    {
        string input = "pwwkew";
        public int Invoke()
        {
            return LengthOfLongestSubstring(input);
        }

        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                HashSet<char> set = new HashSet<char>();
                int curLength = 0;

                for (int j = i; j < s.Length; j++)
                {
                    if (set.Add(s[j]))
                        curLength++;
                    else
                        break;
                }
                if (curLength > maxLength)
                    maxLength = curLength;
            }

            return maxLength;
        }
    }
}
