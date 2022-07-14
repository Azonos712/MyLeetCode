using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task724 : ILeetCodeTask<int>
    {
        int[] input = { 1, 7, 3, 6, 5, 6 };

        public int Invoke()
        {
            return PivotIndex(input);
        }

        public int PivotIndexSlow(int[] nums)
        {
            int[] sums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var rightSum = 0;
                for (int j = i + 1; j < nums.Length; j++)
                    rightSum += nums[j];

                if (sums[i] + (i - 1 < 0 ? 0 : sums[i - 1]) == rightSum)
                    return i;
                else
                    sums[i] = nums[i] + (i - 1 < 0 ? 0 : sums[i - 1]);
            }
            return -1;
        }

        public int PivotIndex(int[] nums)
        {
            int length = nums.Length;
            int[] sums = new int[length];
            for (int i = 1; i < length; i++)
                sums[i] = nums[i - 1] + sums[i - 1];

            for (int i = 0; i < length; i++)
                if (sums[i] == sums[length - 1] + nums[length - 1] - sums[i] - nums[i])
                    return i;

            return -1;
        }
    }
}
