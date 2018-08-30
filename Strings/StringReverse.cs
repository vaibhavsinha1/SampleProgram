using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class StringReverse
    {
        private String str = "A man, a plan, a canal: Panama";
        public string StringReverse1()
        {
            StringBuilder s = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
                s.Append(str.ElementAt(i));

            return s.ToString();
        }
    }
}
