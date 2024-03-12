using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class AddTwoNums_2
    {
        public class ListNode
        {
              public int val;
              public ListNode next;
              public ListNode(int val = 0, ListNode next = null)
              {
                   this.val = val;
                   this.next = next;
              }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            int val=AdditionCheck(l1.val,l2.val, ref carry);
            ListNode l = new ListNode(val);
            ListNode returnNode = l;
            
            while(l1.next!=null || l2.next!=null)
            {
                int val1=NodeVal(ref l1);
                int val2 = NodeVal(ref l2);
                val=AdditionCheck(val1,val2,ref carry);
                l=l.next=new ListNode(val);
                
            }
            if (carry!=0)
                l.next=new ListNode(carry);
            return returnNode;
        }

        public int AdditionCheck(int n1,int n2, ref int carry)
        {
            int lastCarry = carry;
            carry=(n1+n2+lastCarry)/10;
            return carry==0?n1+n2+lastCarry:(n1 + n2 + lastCarry)-10;
        }

        public int NodeVal(ref ListNode l)
        {
            
            if (l.next==null) return 0;
            l=l.next;
            int val = l.val;
            return val;
        }
    }
}
