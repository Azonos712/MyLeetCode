using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._1_Easy
{
    public class Task202 : ILeetCodeTask<bool>
    {
        public bool Invoke() => IsHappy(2);

        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(n);
            string str = n.ToString();

            while (n != 1)
            {
                n = 0;
                foreach (char c in str)
                {
                    int digit = Convert.ToInt32(Char.GetNumericValue(c));
                    n += digit * digit;
                }

                str = n.ToString();
                if (set.Contains(n))
                    return false;
                else
                    set.Add(n);
            }

            return true;
        }
    }
}
