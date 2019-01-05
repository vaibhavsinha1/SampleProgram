using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/887/
    /// </summary>
    public class LongestCommonPrefix
    {
        public String LongestCommonPrefix1(string[] strs)
        {
            if (strs.Length == 0)
                return String.Empty;

            if (strs.Length == 1)
                return strs[0];

            String lcp = String.Empty;
            int count = 0;
            bool b = false;
            String s = String.Empty;
            for (int i = 0; i < strs[0].Length; i++)
            {
                count = 0;
                foreach (var item in strs)
                {
                    if (count == 0)
                    {
                        s  = item.Substring(0, i+1);
                    }
                    else
                    {
                        if (!CommonPrefix(s, item, i+1))
                        {
                            b = true;
                            break;
                        }
                    }
                    count++;
                }
                if (b)
                    break;
                else
                    lcp = s;
            }

            return lcp;
        }

        public bool CommonPrefix(String s, String str, int c)
        {
            bool b = false;
            if (!String.IsNullOrWhiteSpace(str) && str.Length >= c)
                if (str.Substring(0, c).Equals(s))
                    b = true;
            return b;
        }
    }
}
