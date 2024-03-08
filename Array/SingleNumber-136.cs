using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SingleNumber_136
    {
        public static int SingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Where(group => group.Count()==1).Select(group => group.Key).First();
        }
    }
}
