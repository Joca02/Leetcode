using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class SubsequenceWithLargestSum_2099
    {
        public static int[] MaxSubsequence(int[] nums, int k)
        {
            var dict=new SortedDictionary<int,int>();
            var list=new List<int?>(nums.Select(x=>(int?)x));
            for(int i=0;i<k;i++)
            {
                int max =(int) list.Max(x=>x);
                int index = list.IndexOf(max);
                list[index]=null;
                dict.Add(index,max);
                
            }

            int [] result = new int[k];
            int j = 0;
            foreach(var num in dict.Values)
            {
                result[j++]=num;
            }
            return result;
        }
    }
}
