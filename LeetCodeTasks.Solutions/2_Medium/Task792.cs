using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task792 : ILeetCodeTask<int>
    {
        string _s = "abcde";
        string[] _words = { "a", "bb", "acd", "ace" };

        public int Invoke() => NumMatchingSubseq(_s, _words);

        public int NumMatchingSubseq(string s, string[] words)
        {
            int count = 0;

            for (int i = 0; i < words.Length; i++)
                if (IsSubseq(s, words[i]))
                    count++;

            return count;
        }

        private bool IsSubseq(string source, string subseq)
        {
            for (int i = 0, j = -1; i < subseq.Length; i++)
            {
                while (j < source.Length)
                {
                    j++;
                    if (j == source.Length)
                        return false;
                    if (source[j] == subseq[i])
                        break;
                }
            }

            return true;
        }
    }
}
