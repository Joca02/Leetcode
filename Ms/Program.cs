using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddTwoNums_2.ListNode l1=new AddTwoNums_2.ListNode(2);
            AddTwoNums_2.ListNode pom = new AddTwoNums_2.ListNode(4);
            AddTwoNums_2.ListNode r1 = l1;
            l1=l1.next= pom;
            pom = new AddTwoNums_2.ListNode(3);
            l1.next= pom;

            AddTwoNums_2.ListNode l2 = new AddTwoNums_2.ListNode(5);
            AddTwoNums_2.ListNode r2 = l2;
            pom = new AddTwoNums_2.ListNode(6);
            l2=l2.next= pom;
            pom = new AddTwoNums_2.ListNode(4);
            l2.next = pom;

            AddTwoNums_2 program=new AddTwoNums_2();
            program.AddTwoNumbers(r1,r2);
        }
    }
}
