using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeTasks.Solutions._2_Medium.Task729;

namespace LeetCodeTasks.Solutions._2_Medium
{
    public class Task729 : ILeetCodeTask<bool>
    {
        public bool Invoke()
        {
            MyCalendar obj = new MyCalendar();
            //bool test1 = obj.Book(10, 20);
            //bool test2 = obj.Book(15, 25);
            //bool test3 = obj.Book(20, 30);
            bool test4 = obj.Book(69, 70);
            bool test5 = obj.Book(3, 4);
            bool test6 = obj.Book(39, 40);
            bool test7 = obj.Book(35, 36);
            bool test8 = obj.Book(3, 4);

            return obj.Book(15, 20);
        }

        public class MyCalendar
        {
            SortedList<int, int> _events;
            KeyValuePair<int, int> _defaultValue = new KeyValuePair<int, int>(-1, -1);

            public MyCalendar() => _events = new SortedList<int, int>();

            public bool Book(int start, int end)
            {
                if (_events.ContainsKey(start))
                    return false;

                KeyValuePair<int, int> left = _events.Where(x => x.Key < start).LastOrDefault(_defaultValue);

                KeyValuePair<int, int> right = _events.Where(x => x.Key > start).FirstOrDefault(_defaultValue);

                if (left.Key != -1 && left.Value != -1)
                    if (left.Value > start)
                        return false;

                if (right.Key != -1 && right.Value != -1)
                    if (right.Key < end)
                        return false;

                _events.Add(start, end);
                return true;
            }
        }
    }
}
