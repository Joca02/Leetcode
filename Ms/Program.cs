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
           

            MergeSortedLists_21 a=new MergeSortedLists_21();
            MergeSortedLists_21.ListNode w=new MergeSortedLists_21.ListNode();
            MergeSortedLists_21.ListNode list = w;
            /*w=w.next=new MergeSortedLists_21.ListNode(1);
            w=w.next=new MergeSortedLists_21.ListNode(2);
            w=w.next=new MergeSortedLists_21.ListNode(4);*/

            MergeSortedLists_21.ListNode s = new MergeSortedLists_21.ListNode(0);
            MergeSortedLists_21.ListNode list2 = s;
            /*s=s.next=new MergeSortedLists_21.ListNode(1);
           s=s.next=new MergeSortedLists_21.ListNode(3);
            s = s.next = new MergeSortedLists_21.ListNode(4);*/
            a.MergeTwoLists(list,list2);
           
        }
    }
}
