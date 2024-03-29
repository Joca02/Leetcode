using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Ms
{
    internal class LongestSubstringWOutRepeatingChars_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            int longestLen = 0;
            int len = 0;
            for(int i=0; i < s.Length;i++)
            {
                if (chars.Contains(s[i]))
                {
                    len=chars.Count;
                    i-=len-1;
                    chars.Clear();
                   
                    if(len> longestLen) longestLen = len;
                    len=0;

                    
                }

                chars.Add(s[i]);
                 len++;
                
            }
            if(len> longestLen) longestLen = len;
            return longestLen;
        }
    }
}
