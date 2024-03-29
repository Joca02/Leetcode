using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class ZigZagConversion_6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows) return s;

            StringBuilder sb = new StringBuilder();
            int moveIndex = numRows * 2 - 2;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = i; j < s.Length; j += moveIndex)
                {
                    sb.Append(s[j]);
                    if (i > 0 && i < numRows - 1)
                    {
                        int nextJ = j + moveIndex - 2 * i;
                        if (nextJ < s.Length)
                            sb.Append(s[nextJ]);
                    }
                }
            }

            return sb.ToString();

        }
    }
}
