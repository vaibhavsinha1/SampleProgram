using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class CustomClass
    {
        public string findNumber(List<int> arr, int k)
        {
            if (arr.Exists(i => i == k))
                return "YES";
            else
                return "NO";

        }

        public List<int> oddNumbers(int l, int r)
        {
            var c = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    c.Add(i);
                }
            }

            return c;

        }

    }


}
