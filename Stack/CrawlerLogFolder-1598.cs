using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class CrawlerLogFolder_1598
    {
        public static void Main()
        {
            Console.WriteLine(MinOperations(new string[]{ "./", "../", "./" }  ));
        }
        public static int MinOperations(string[] logs)
        {
            Stack<string> stack = new Stack<string>();
            foreach (string log in logs)
            {
                if(log=="../" && stack.Count > 0) stack.Pop();
                else if(log=="./")continue; 
                else stack.Push(log);
            }
            return stack.Count;
        }

    }
}
