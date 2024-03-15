using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class DivideTwoInts_29
    {
        public static int Divide(int dividend, int divisor)
        {
            if (dividend>int.MaxValue || divisor>int.MaxValue)
                return int.MaxValue;
            else if (dividend<int.MinValue || divisor<int.MinValue)
                return int.MinValue;
            int sign = ((dividend<0&&divisor>0)||dividend>0&&divisor<0) ? -1 : 1;
            int result = 0;
            try
            {
                dividend=Math.Abs(dividend);
                divisor=Math.Abs(divisor);
            }
            catch (Exception)
            {
                return sign<0?int.MinValue:int.MaxValue;
            }
            
            while (true)
            {
                dividend-=divisor;
                result++;
                if (dividend<0)
                    break;
            }
            return --result*sign;
        }
    }
}
