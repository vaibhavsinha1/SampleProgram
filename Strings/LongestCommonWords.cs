using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class LongestCommonWords
    {
        string[] user0 = { "Hello", "Sample1", "Sample2", "Sample3", "Samplex", "Sampley", "Samplez" };
        string[] user1 = { "Hello1", "Samplen", "Sample2", "Sample3", "Samplex", "Samplex", "Sampley" };

        public void LongestCommonWords1()
        {
            var list = GetCommonWords(user0, user1);

            foreach (var item in list)
                Console.WriteLine(item);
        }

        private List<String> GetCommonWords(String[] user0, string[] user1)
        {
            var result = new List<String>();
            var subresult = new List<String>();
            int count = 0;
            bool found = false;
            for(int i = 0; i<user0.Count(); i++)
            {
                subresult = new List<string>();
                found = false;
                count = i;
                for (int j = 0; j<user1.Count(); j++)
                {
                    if (count < user0.Count())
                    {
                        if (user0[count] == user1[j])
                        {
                            subresult.Add(user0[count]);
                            count++;
                            found = true;
                        }
                        else if (found)
                        {
                            break;
                        }
                    }
                   
                }
                if(subresult.Count > result.Count )
                {
                    result = subresult;
                }
            }
            return result;
        }

    }

    
}

