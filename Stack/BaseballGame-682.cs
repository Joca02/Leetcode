using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class BaseballGame_682
    {
        public static void Main()
        {
            CalPoints(new string[] { "5", "2", "C", "D", "+" });
        }



        public static int CalPoints(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var operation in operations)
            {
                if(int.TryParse(operation, out var points))
                {
                    stack.Push(points);
                }
                else if(stack.Count>0)
                {
                    if(operation=="+" )
                    {
                        if (stack.Count>=2)
                            stack.Push(stack.Peek()+stack.ElementAt(1));
                        else stack.Push(stack.Peek());
                            
                    }
                    else if(operation=="C")
                    {
                        stack.Pop();
                    }
                    else if (operation=="D")
                    {
                        stack.Push(2*stack.Peek());
                    }

                }
            }
            return stack.Sum();
        }
    }


}
