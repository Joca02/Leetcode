using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class JumpGame_55
    {
        static void Main()
        {
           Console.WriteLine( CanJump(new int[] { 3,1,0,1,4,0,0,0,7 }));
        }
        public static bool CanJump(int[] nums)
        {
            if (!nums.Contains(0) || nums.Count()==1)
                return true;
            if (nums[0]==0)return false;
            Dictionary<int,bool>targets= new Dictionary<int,bool>();
            targets.Add(nums.Length-1, false);
            for(int i=nums.Length-2;i>=0;i--)
            {
                int targetIndex = targets.Keys.Last();
                if (i+nums[i]>=targetIndex)
                {
                    targets[targetIndex]=true;
                    if(i>1)targets.Add(i, false);
                }
            }
            return targets.Values.All(x => x==true);
        }
    }
}
