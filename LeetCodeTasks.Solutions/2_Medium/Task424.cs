using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task424 : ILeetCodeTask<int>
    {
        public int Invoke() => CharacterReplacement("AABABBA", 1);

        public int CharacterReplacement(string s, int k)
        {
            int maxLength = 0;
            Dictionary<char, int> chars = new Dictionary<char, int>();
            int l = 0, r = 0;

            while (r < s.Length)
            {
                if (!chars.TryAdd(s[r], 1))
                    chars[s[r]]++;

                int window = r - l + 1;
                int maxLetters = chars.Values.Max();
                if (window - maxLetters <= k)
                {
                    if (maxLength <= window)
                        maxLength = window;
                    r++;
                }
                else
                {
                    if (chars[s[l]] > 1)
                        chars[s[l]]--;
                    else
                        chars.Remove(s[l]);

                    l++;
                    r++;
                }
            }

            return maxLength;
        }
    }
}
