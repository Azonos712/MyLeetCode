using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task299 : ILeetCodeTask<string>
    {
        public string Invoke() => GetHint("1123", "0111");
        public string GetHint(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in secret)
                if (!map.TryAdd(c, 1))
                    map[c]++;

            for (int i = 0; i < secret.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    bulls++;
                    cows--;
                }

                if (map.ContainsKey(guess[i]) && map[guess[i]] > 0)
                {
                    map[guess[i]]--;
                    cows++;
                }
            }

            return bulls + "A" + cows + "B";
        }
    }
}
