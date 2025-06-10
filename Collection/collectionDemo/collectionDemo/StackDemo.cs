using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionDemo
{
    internal class StackDemo
    {
        public static void StackOperation()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Pop();
            foreach (int i in stk)
            {
                Console.WriteLine(i);


            }
        }
    }
}
