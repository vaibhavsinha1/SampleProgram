using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Fibannoci
    {
        public int Fibannoci1(int n)
        {
            int []f = new int[n + 2]; //in case n =0;
            f[0] = 0;
            f[1] = 1; 
            for(int i = 2; i<=n;i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];    
        }

        public int Fibannoci2(int n)
        {
            int a = 0;
            int b  = 1;
            int c;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
