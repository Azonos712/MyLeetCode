using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._3_Hard
{
    public class Task4 : ILeetCodeTask<double>
    {
        int[] input1 = { 1, 2 };
        int[] input2 = { 3, 4 };

        public double Invoke()
        {
            return FindMedianSortedArrays(input1, input2);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = nums1
                .Concat(nums2)
                .OrderBy(x => x)
                .ToArray();

            double result;
            int l = nums.Length;

            if (nums.Length % 2 == 0)
                result = (double)(nums[(l / 2) - 1] + nums[l / 2]) / 2;
            else
                result = nums[l / 2];

            return result;
        }
    }
}
