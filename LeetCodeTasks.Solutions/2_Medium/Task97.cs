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
        //string[] s = new string[] { "aa", "ab", "aaba" }; // true
        string[] s = new string[] { "ab", "bc", "bbac" }; // true

        public bool Invoke()
        {
            return IsInterleave(s[0], s[1], s[2]);
        }

        /// <summary>
        /// Time: O(n*m) / Memory: O(n*m)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            var grid = new bool?[s1.Length + 2, s2.Length + 2];
            for (int i = 0; i < grid.GetLength(1); i++)
                grid[grid.GetLength(0) - 1, i] = false;
            for (int i = 0; i < grid.GetLength(0); i++)
                grid[i, grid.GetLength(1) - 1] = false;

            int p1 = 0;
            int p2 = 0;
            grid[p1, p2] = true;
            bool isNewLine = false;
            while (true)
            {
                if (p1 == s1.Length && p2 == s2.Length)
                    return grid[p1, p2].Value;

                if (grid[p1 + 1, p2] == false && grid[p1, p2 + 1] == false)
                    grid[p1, p2] = false;

                if (p1 == 0 && p2 == 0 && grid[p1, p2] == false)
                    return false;

                if (grid[p1, p2] == true)
                {
                    if (grid[p1 + 1, p2] == false)
                    {
                        p2++;
                        isNewLine = true;
                    }
                    else
                        p1++;
                }
                else if (grid[p1, p2] == false && p1 > 0 && grid[p1 - 1, p2] == true)
                {
                    p1--;
                }
                else
                {
                    p2--;
                }

                if (grid[p1, p2] == null)
                {
                    if (!isNewLine)
                    {
                        if (s1[p1 - 1] == s3[p1 + p2 - 1])
                        {
                            grid[p1, p2] = true;
                            continue;
                        }
                        else
                        {
                            grid[p1, p2] = false;
                            continue;
                        }
                    }

                    isNewLine = false;

                    if (s2[p2 - 1] == s3[p1 + p2 - 1])
                    {
                        grid[p1, p2] = true;
                        continue;
                    }
                    else
                    {
                        grid[p1, p2] = false;
                        p2--;
                        continue;
                    }
                }
            }


            return true;
        }

    }
}
