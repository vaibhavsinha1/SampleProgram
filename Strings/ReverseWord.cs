using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ReverseWord
    {
        public string s ="  Hello how     are you";

        public String ReverseWord1()
        {
            StringBuilder str = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(s))
            {
                s = s.Trim();
                char[] s2 = { ' ' };
                var s1 = s.Split(s2, StringSplitOptions.RemoveEmptyEntries);
                for (int i = s1.Length - 1; i >= 0; i--)
                    str.Append(s1[i] + " ");
            }
            return str.ToString().Trim();
        }
    }
}
