using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task97 : ILeetCodeTask<bool>
    {
        //string[] s = new string[] { "aabcc", "dbbca", "aadbbcbcac" }; //true
        //string[] s = new string[] { "aabcc", "dbbca", "aadbbbaccc" }; // false
        //string[] s = new string[] { "", "", "a" }; // false
        //string[] s = new string[] { "", "b", "b" }; // true
        //string[] s = new string[] { "a", "b", "a" }; // false
        string[] s = new string[] { "aa", "ab", "aaba" }; // false

        public bool Invoke()
        {
            return IsInterleave(s[0], s[1], s[2]);
        }

        private bool CheckSubString(ref string source, ref string sub)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                if (i + 1 == sub.Length && source[i] == sub[i])
                {
                    source = source.Substring(i + 1);
                    sub = sub.Substring(i + 1);
                    return true;
                }

                if (source[i] != sub[i])
                {
                    if (i == 0)
                        return false;
                    source = source.Substring(i);
                    sub = sub.Substring(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Don`t work
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            while (s3.Length != 0)
            {
                bool first = CheckSubString(ref s3, ref s1);

                if (first && s3.Length == 0 && s2.Length != 0)
                    return false;

                if (first && s3.Length == 0)
                    return true;

                bool second = CheckSubString(ref s3, ref s2);

                if (s3.Length == 0)
                    return first || second;

                if (first != true || second != true)
                    return false;
            }

            return true;

        }

    }
}
