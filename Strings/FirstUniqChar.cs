using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Strings
{
    public class FirstUniqChar
    {
        private string s = "loveleetcode";

        public int FirstUniqChar1()
        {
            int index = -1;
            char[] a = new char[26];
            for(int i=0; i<s.Length; i++)
            {
                var b = s.ElementAt(i);
                
                a[s.ElementAt(i) - 'a']++; 
            }

            for(int i=0; i<s.Length;i++)
            {
                if (a[s.ElementAt(i) - 'a'] == 1)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        //This will be the unique character in the sort order.
        public int FirstUniqChar2()
        {
            int index = -1;
            char[] chara = SortString(s);
            for(int i = 0; i<chara.Length; i=i+2)
            {
                if (chara[i] != chara[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private char[] SortString(string s)
        {
            char[] chara = s.ToCharArray();
            Array.Sort(chara);
            return chara;
        }
    }
}
