using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class NUniqueIntsSumUpToZero_1304
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            int num = n-1;
            int condition=n%2==0 ? 0 : 1;
            for (int i = n-1; i >= condition; i--)
            {
                result[i]=num;
                result[--i]=-num--;

            }
            return result;
        }
    }
}
