using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class _1021
    {
      /*  public static void Main(string[] args)
        {
            Console.WriteLine(RemoveOuterParentheses("(()())(())(()(()))"));
        }*/

        static string RemoveOuterParentheses(string s)
        {
            string res = "";
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if (c=='(')
                {
                    if (stack.Count > 0) res+=c;
                    stack.Push(c);
                }
                    
                else if (c==')')
                {
                    stack.Pop();
                    if(stack.Count > 0)res+=c;
                }

            }

            return res;
        }
    }
}
