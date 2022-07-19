using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task278 : ILeetCodeTask<int>
    {
        int _n = 5;

        public int Invoke() => FirstBadVersion(_n);

        /// <summary>
        /// Time: O(logn) / Memory: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersion(int n)
        {
            long l = 0;
            long r = n - 1;
            int result = n;

            while (l <= r)
            {
                int mid = (int)((l + r) / 2);
                bool version = IsBadVersion(mid + 1);

                if (version == true)
                {
                    r = mid - 1;
                    result = mid + 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return result;
        }

        private bool IsBadVersion(int v)
        {
            if (v == 3)
                return false;

            return true;
        }
    }
}
