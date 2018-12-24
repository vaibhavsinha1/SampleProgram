using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class PalindromePartitioning
    {
        //TODO: Not yet completed
        //Palindrome p = new Palindrome();
        String s = "aab";
        public String TestP()
        {
            var l = PalindromePartitioning1();

            return "s";
        }
        public IList<IList<string>> PalindromePartitioning1()
        {
            var ans = new List<IList<string>>();
            for (int i = 1; i <= s.Length; i++)
            {
               var ls = AllPartition(s, 0, i);
                if(ls.Count > 0)
                    ans.Add(ls);
            }

            return ans;
        }

        private List<String> AllPartition(String s, int start, int part)
        {
            String str;
            int total;
            var ls = new List<String>();
            for (int i = start; i < s.Length; i++)
            {
                if (i + part <= s.Length)
                {
                    str = s.Substring(i, part);
                    if (isPalindrome(str))
                    {
                        ls.Add(str);
                    }
                }
                else
                {
                    //total = i + part;
                    //part = 
                }
            }
            return ls;
        }

        private bool isPalindrome(String str)
        {
            int len = str.Length;
            len--;
            for (int i = 0; i < len; i++)
            {
                if (str.ElementAt(i) != str.ElementAt(len))
                    return false;
                len--;
            }
            return true;
        }
    }
}
