using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Palindrome
    {
        String s2 = "civic";
        public bool Palindrome2(String s1)
        {

            string r = s1;
            bool b = false;
            b  = r.Reverse().Equals(s1);

            return b;
        }
        public bool Palindrome1(String s)
        {
            s= s.ToLower();
            bool b = true;
            bool c = false;
            int j = s.Length-1;
            int i = 0;
            while(i<s.Length && j>=0)
            {
                c = false;
                if (!isAlphaNumeric(s.ElementAt(i)))
                {
                    i++;
                    c = true;
                }
                if (!isAlphaNumeric(s.ElementAt(j)))
                {
                    j--;
                    c= true;
                }
                if (c)
                    continue;
                if (s.ElementAt(i) != s.ElementAt(j))
                {
                    b = false;
                    break;
                }
                i++;
                j--;
            }
            return b;
        }

        private bool isAlphaNumeric(char a)
        {
            return Regex.IsMatch(a.ToString(), "[a-z0-9]", RegexOptions.IgnoreCase); ;
        }

    }
}
