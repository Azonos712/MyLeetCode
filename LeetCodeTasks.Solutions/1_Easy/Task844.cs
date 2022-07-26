using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task844 : ILeetCodeTask<bool>
    {
        public bool Invoke() => BackspaceCompare("ab#c", "ad#c");

        public bool BackspaceCompare(string s, string t)
        {
            return ProcessString(s) == ProcessString(t);
        }

        /// <summary>
        /// Also we can use Stack
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ProcessString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '#')
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
