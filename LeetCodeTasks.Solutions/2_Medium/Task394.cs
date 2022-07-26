using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task394 : ILeetCodeTask<string>
    {
        public string Invoke() => DecodeString("3[a]2[bc]");

        public string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ']')
                    stack.Push(s[i]);
                else
                {
                    StringBuilder sb1 = new StringBuilder();

                    while (stack.Peek() != '[')
                        sb1.Insert(0, stack.Pop());

                    stack.Pop();

                    StringBuilder sb2 = new StringBuilder();
                    while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                        sb2.Insert(0, stack.Pop());
                    int k = int.Parse(sb2.ToString());

                    for (int l = 0; l < k; l++)
                        for (int j = 0; j < sb1.Length; j++)
                            stack.Push(sb1[j]);

                }
            }

            return new string(stack.Reverse().ToArray());
        }
    }
}
