using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class PlusOne_66
    {

        public static int[] PlusOne(int[] digits)
        {
            for(int i=digits.Length-1; i>=0; i--)
            {
                if (digits[i]+1<=9)
                {
                    digits[i]++;
                    return digits;
                }
                else digits[i]=0;
                
            }
            int[] arr = new int[digits.Length+1];
            arr[0]=1;
            for(int i=1; i<digits.Length+1; i++)
                arr[i] =0;
            return arr;
            
        }
    }
}
