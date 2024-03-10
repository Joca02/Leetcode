using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class PascalsTriangle_118
    {
      /*  static void Main()
        {
            Generate(4);
        }*/
        static public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>>list = new List<IList<int>>();
            for(int i = 0; i < numRows; i++)
            {
                list.Add(new List<int>());
                for(int j = 0; j <= i; j++)
                {
                    
                    if (j==i || j==0)
                        list[i].Add(1);
                    else
                    {
                        list[i].Add(list[i-1][j-1]+list[i-1][j]);
                    }
                    
                }
            }
            return list;
           
        }
    }
}
