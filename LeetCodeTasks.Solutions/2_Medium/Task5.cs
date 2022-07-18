using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task5 : ILeetCodeTask<string>
    {
        string _str = "aaaa";

        public string Invoke() => LongestPalindrome(_str);

        public string LongestPalindrome(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int left = i, right = i + j;

                    while (left >= 0 && right < s.Length && s[left] == s[right])
                    {
                        string sub = s.Substring(left, right - left + 1);
                        if (result.Length < sub.Length)
                            result = sub;
                        left--;
                        right++;
                    }

                }
            }

            return result;
        }
    }
}
