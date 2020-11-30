using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/171/
    public class StringToInteger
    {
        private string str = "ere456";
        
        public int StringToInteger1()
        {
            int i = 0;
            int sign = 1;
            int result = 0;
            int s;
            int zero = '0';
            if (str.Length <= 0) return 0;
            while (i < str.Length && str.ElementAt(i) == ' ') i++;
            if (i < str.Length && (str.ElementAt(i) == '-' || str.ElementAt(i) == '+'))
            {
                sign = str.ElementAt(i++) == '-' ? -1 : 1;
            }
            while (i < str.Length)
            {
                if (str.ElementAt(i) >= '0' && str.ElementAt(i) <= '9')
                {
                    s = str.ElementAt(i);
                    s = s - zero;
                    result = result * 10 + str.ElementAt(i) - '0';
                }
                i++;
            }

            
            return sign * result;
        }
    }
}
