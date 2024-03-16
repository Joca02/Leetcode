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
            RemoveDuplicatesFromSortedList_83 a=new RemoveDuplicatesFromSortedList_83();
            RemoveDuplicatesFromSortedList_83.ListNode w=new RemoveDuplicatesFromSortedList_83.ListNode(1);
            RemoveDuplicatesFromSortedList_83.ListNode list =w;
            w=w.next=new RemoveDuplicatesFromSortedList_83.ListNode(1);
            w=w.next=new RemoveDuplicatesFromSortedList_83.ListNode(2);
            w=w.next=new RemoveDuplicatesFromSortedList_83.ListNode(3);
            w=w.next=new RemoveDuplicatesFromSortedList_83.ListNode(3);
            a.DeleteDuplicates(list);
           
        }
    }
}
