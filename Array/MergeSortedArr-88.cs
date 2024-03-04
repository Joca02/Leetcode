using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MergeSortedArr_88
    {

        static void Main()
        {
            int[] n1 = new int[] { 0};
            Merge(n1, , new int[] {  }, 0);
            foreach(var i in n1)
            {
                Console.WriteLine(i);
            }
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int counter = 0;
            try
            {
                for (int i = 0; i < m+n; i++)
                {
                    if (nums1[i] > nums2.Min() && i<m)
                    {
                        int index2 = Array.IndexOf(nums2, nums2.Min());
                        int pom = nums2[index2];
                        nums2[index2] = nums1[i];
                        nums1[i] = pom;
                    }
                    else if (i>=m && counter<n)
                    {
                        ++counter;
                        nums1[i]=nums2.Min();
                        int indMin = Array.IndexOf(nums2, nums2.Min());
                        nums2[indMin] = nums2.Max();

                    }
                }
            }catch (Exception e) { return; }
           
        }
    }
}
