using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task1480 : ILeetCodeTask<int[]>
    {
        int[] input = new int[] { 1, 2, 3, 4 };
        public int[] Invoke()
        {
            return RunningSum(input);
        }

        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
                nums[i] = nums[i] + nums[i - 1];

            return nums;
        }
    }
}