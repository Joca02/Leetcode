using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class ThreeSum_15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result= new List<IList<int>>();
            for (int i = 0; i < nums.Length-2; i++)
            {
                int startNum = nums[i];
                int left = i+1;
                int right = nums.Length-1;
                while (left < right)
                {
                    int neededNum = -startNum;
                    int twoSum=nums[left] +nums[ right];
                    if (neededNum<twoSum)
                        right--;

                    else if (neededNum>twoSum)
                        left++;
                    else
                    {
                        bool found = false;
                        foreach (var list in result)
                        {
                            if (list[0]==startNum && list[1]==nums[left])
                            {
                                found=true;
                                break;
                            }
                           
                        }
                        if (!found) result.Add(new List<int>() { startNum, nums[left], nums[right] });
                        left++;
                    }
                }
            }
            return result;
           
        }
    }
}
