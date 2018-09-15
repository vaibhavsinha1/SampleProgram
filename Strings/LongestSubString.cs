using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class LongestSubString
    {
        String s = "abcabcbb";
        public void LongestSubString1()
        {
            s = String.Concat(s.OrderBy(c => c));

            //for (int i = 0; i < length; i++)
            //{

            //}
        }

    }
}
