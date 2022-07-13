using LeetCodeTasks.Solutions;
using LeetCodeTasks.Solutions._1_Easy;
using LeetCodeTasks.Solutions._2_Medium;
using LeetCodeTasks.Solutions._3_Hard;
using System;
using static LeetCodeTasks.Solutions._2_Medium.Task2;

namespace LeetCodeTasks.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILeetCodeTask<IList<IList<int>>> task = new Task102();
            var result = task.Invoke();
            System.Console.WriteLine(string.Join(',', result));
        }
    }
}