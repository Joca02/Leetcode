using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class FindDuplicateNum_287
    {
        static void Main()
        {
            Console.WriteLine(FindDuplicate(new int[] {1,2,34,7,1,3}));
        }

        public static int FindDuplicate(int[] nums)
        {
            //return nums.GroupBy(num => num).Where(group => group.Count()>1).Select(group => group.Key).First();
            Array.Sort(nums);
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i-1])return nums[i];
            }
            return -1;
        }
    }
}
