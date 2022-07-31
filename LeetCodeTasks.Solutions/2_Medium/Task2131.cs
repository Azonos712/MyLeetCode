using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task2131 : ILeetCodeTask<int>
    {
        string[] _words = new string[] { "em", "pe", "mp", "ee", "pp", "me", "ep", "em", "em", "me" };

        public int Invoke() => LongestPalindrome(_words);

        public int LongestPalindrome(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int result = 0;
            foreach (string word in words)
            {
                string wordReverce = new string(word.Reverse().ToArray());
                if (!dict.ContainsKey(wordReverce))
                {
                    if (!dict.ContainsKey(word))
                        dict.Add(word, 1);
                    else
                        dict[word]++;
                }
                else
                {
                    dict[wordReverce]--;
                    result += 4;

                    if (dict[wordReverce] == 0)
                        dict.Remove(wordReverce);
                }
            }

            foreach (var pair in dict)
            {
                if (pair.Value == 1 && pair.Key[0] == pair.Key[1])
                {
                    result += 2;
                    break;
                }
            }

            return result;
        }
    }
}
