using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class SignOfTheProductOfAnArray_1822
    {
        public int ArraySign(int[] nums)
        {
            if (nums.Contains(0)) return 0;
            return nums.Where(x => x<0).Count()%2==0 ? 1 : -1;
        }
    }
}
