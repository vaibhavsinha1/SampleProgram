using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Strings
{
    public class Str
    {
        string haystack = "heokl";
        string needle = "ll";
        public int StrStr1()
        {
            int index = -1;
            int l1 = haystack.Length;
            int l2 = needle.Length;
            if (l2 == 0)
                return 0;
            if (l1 < l2)
                return index;

            for(int i =0; i<=l1-l2; i++)
            {
                if (haystack.Substring(i, l2) == needle)
                    return i;
            }

            return index;
        }
    }
}
