using LeetCodeTasks.Solutions;
using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions._2_Medium;
using LeetCodeTasks.Solutions._3_Hard;
using LeetCodeTasks.Solutions.Utility;
using System;

namespace LeetCodeTasks.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILeetCodeTask<IList<int>> task = new Task54();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}