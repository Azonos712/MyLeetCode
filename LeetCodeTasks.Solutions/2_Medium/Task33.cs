using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task33 : ILeetCodeTask<int>
    {
        int[] _nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };

        public int Invoke() => Search(_nums, 3);

        public int Search(int[] nums, int target)
        {
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                    k = i - 1;
            }

            int left = BinarySearch(nums, 0, k, target);
            int right = BinarySearch(nums, k + 1, nums.Length - 1, target);

            return Math.Max(left, right);
        }

        public int BinarySearch(int[] nums, int l, int r, int target)
        {
            while (l <= r)
            {
                int index = (l + r) / 2;

                if (target == nums[index])
                    return index;

                if (target < nums[index])
                    r = index - 1;
                else
                    l = index + 1;
            }

            return -1;
        }
    }
}
