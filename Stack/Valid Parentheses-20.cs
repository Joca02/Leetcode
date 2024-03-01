using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class _20
    {
        static void Main(string[] args)
        {
            Console.WriteLine( isValid("({}[[]])"));
        }


        static public bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c=='{'||c=='['||c=='(')
                    stack.Push(c);
                else if (c=='}'||c==']'||c==')')
                {
                    switch (c)
                    {
                        case '}':
                            if(stack.Count > 0)
                            {
                                if (stack.Pop()=='{')
                                    continue;
                                else return false;
                            }
                            else return false;
                           
                        case ']':
                            if (stack.Count > 0)
                            {
                                if (stack.Pop()=='[')
                                    continue;
                                else return false;
                            }
                            else return false;
                        case ')':
                            if (stack.Count > 0)
                            {
                                if (stack.Pop()=='(')
                                    continue;
                                else return false;
                            }
                            else return false;
                    }

                }
                else return false;

            }
            if (stack.Count == 0) return true;
            return false; //ako nema ni1 char
        }
       
    }
}
