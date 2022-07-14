using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task205 : ILeetCodeTask<bool>
    {
        //string s1 = "ackvva";
        //string s2 = "ackvck";
        string s1 = "abcdefghijklmnopqrstuvwxyzva";
        string s2 = "abcdefghijklmnopqrstuvwxyzck";

        public bool Invoke()
        {
            return IsIsomorphic(s1, s2);
        }

        public bool IsIsomorphic(string s, string t)
        {
            string sRes = ConvertString(s);
            string tRes = ConvertString(t);

            return sRes == tRes;
        }

        private string ConvertString(string str)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<char, char> chars = new Dictionary<char, char>();
            int code = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (chars.ContainsKey(str[i]))
                {
                    result.Append(chars[str[i]]);
                }
                else
                {
                    chars.Add(str[i], (char)code);
                    result.Append((char)code);
                    code++;
                }
            }
            return result.ToString();
        }
    }
}
