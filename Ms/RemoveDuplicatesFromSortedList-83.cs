using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class RemoveDuplicatesFromSortedList_83
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

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode result = head;
            HashSet<int> hashset= new HashSet<int>();
            ListNode previous= head;
            while(head != null)
            {
                if(!hashset.Contains(head.val))
                {
                    hashset.Add(head.val);
                    previous= head;
                    head = head.next;
                }
                else
                {  
                    head = head.next;
                    previous.next = head;
                }             
            }
            return result;
        }
    }
}
