using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SampleCode.Strings
{
    public class Palindrome
    {
        String s = "civic";
        public bool Palindrome2()
        {

            string r = s;
            bool b = false;
            b  = r.Reverse().Equals(s);

            return b;
        }
        public bool Palindrome1()
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
