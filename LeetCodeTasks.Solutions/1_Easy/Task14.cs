using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task14 : ILeetCodeTask<string>
    {
        public string Invoke() => LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new StringBuilder();
            string shortest = strs.OrderBy(n => n.Length).FirstOrDefault();

            for (int i = 0; i < shortest.Length; i++)
            {
                bool isEqual = true;
                for (int j = 0; j < strs.Length; j++)
                    if (shortest[i] != strs[j][i])
                    {
                        isEqual = false;
                        break;
                    }

                if (isEqual)
                    sb.Append(shortest[i]);
                else
                    break;
            }

            return sb.ToString();
        }
    }
}
