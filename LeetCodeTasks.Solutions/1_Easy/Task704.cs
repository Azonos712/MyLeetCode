using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task704 : ILeetCodeTask<int>
    {
        int[] _nums = { -1, 0, 3, 5, 9, 12 };
        int _target = 2;

        public int Invoke() => Search(_nums, _target);

        /// <summary>
        /// Time: O(logn) / Memory: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                    l = mid + 1;
                else
                    r = mid - 1;

            }

            return -1;
        }
    }
}
