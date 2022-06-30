using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task1 : ILeetCodeTask<int[]>
    {
        int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
        int target = 11;

        public int[] Invoke()
        {
            //return TwoSumSlow(nums, target);
            return TwoSumFast(nums, target);
        }

        /// <summary>
        /// Time: O(n^2) / Memory: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSumSlow(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }

            return null;
        }

        /// <summary>
        /// Time: O(n) / Memory: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSumFast(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new int[] { dict[diff], i };

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            return null;
        }
    }
}
