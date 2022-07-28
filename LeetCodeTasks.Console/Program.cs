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
            ILeetCodeTask<int[]> task = new Task1706();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}