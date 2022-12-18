using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class StackExtensions
    {
        public void Merge(Stack s1, Stack s2)
        {
            //s2.SteckList.Reverse();
            foreach (var item in s2.SteckList)
            {
                s1.Add(item);
            }
            
        }
    }
}
