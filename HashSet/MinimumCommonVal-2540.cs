using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    internal class Program
    {

        public static  int GetCommon(int[] nums1, int[] nums2)
        {
            var s = nums1.Intersect(nums2);
            return s.Count()>0?s.Min():-1;
            
        }
    }
}
