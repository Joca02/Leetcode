using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class RemoveDuplicates_26
    {
       /* static void Main()
        {
            Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }*/

        public static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0) return 0;
            int unique_nums = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i-1])
                {
                    nums[unique_nums++]=nums[i];
                }
            }
            return unique_nums;
        }
    }
}
