using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public static class StackExtensions
    {
        public static List<string> Merge(Stack s1, Stack s2)
        {
            var arr1 = s1.StackToArray(s1).Reverse().ToList();
            var arr2 = s2.StackToArray(s2);

            foreach (var item in arr2)
            {
                arr1.Add(item);
            }
            return arr1;
        }
    }
}
