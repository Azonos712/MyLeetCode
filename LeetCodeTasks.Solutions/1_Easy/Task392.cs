using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task392 : ILeetCodeTask<bool>
    {
        string s1 = "axc";
        string s2 = "ahbgdc";
        public bool Invoke()
        {
            return IsSubsequence(s1, s2);
        }

        public bool IsSubsequence(string s, string t)
        {
            for (int i = 0, j = -1; i < s.Length; i++)
            {
                while (j < t.Length)
                {
                    j++;

                    if (j == t.Length)
                        return false;

                    if (s[i] == t[j])
                        break;
                }
            }

            return true;
        }
    }
}
