using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoSum
    {
       /* static void Main(string[] args)
        {
            TwooSum(new int[] { 3, 2, 4 }, 7);
        }*/

        public static int[] TwooSum(int[] nums, int target)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();
            //key-je vrednost iz niza a val je njegov index
            for (int i = 0; i < nums.Length; i++)
            {
                var needed_num = target - nums[i];

                if (dictNums.ContainsKey(needed_num))
                    return new int[] { dictNums[needed_num], i };

                if (!dictNums.ContainsKey(nums[i]))
                    dictNums[nums[i]] = i;
            }
            
            return new int[] { };
        }
    }
}
