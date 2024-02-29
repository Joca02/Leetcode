using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class MyQueue_232
    {
   
        Stack<int>stack = new Stack<int>();
        Stack<int> queue = new Stack<int>();

        public void GenerateQueue()
        {
            queue.Clear();
            foreach (var item in stack)
            {
                queue.Push(item);
            }
        }

        public void RefreshStack()
        {
            stack.Clear();
            foreach(var item in queue)
                stack.Push(item);
        }
        public void Push(int x)
        {
            stack.Push(x);
            GenerateQueue();

        }

        public int Pop()
        {
            var val=queue.Peek();
            queue.Pop();
            RefreshStack();
            return val;
        }

        public int Peek()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
