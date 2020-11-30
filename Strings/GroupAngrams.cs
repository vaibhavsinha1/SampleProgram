using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    //https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/200/
    public class GroupAngrams
    {

        //String[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        public IList<IList<string>> GroupAngrams1(string[] strs)
        {
            var list = GetGroupAngrams(strs);
            return list;
        }

        private IList<IList<string>> GetGroupAngrams(string[] strs)
        {
            IList<IList<string>> result =  new List<IList<string>>();
            if (strs == null || strs.Length == 0)
                return result;// (IList<IList<string>>)result;

            string input, temp;
            for (int i = 0; i < strs.Length; i++)
            {
                var subresult = new List<String>();
                bool present = false;
                foreach (var list in result)
                {
                    if (list.Contains(strs[i]))
                    {
                        present = true;
                        break;
                    }
                }
                if (present)
                    continue;
                
                subresult.Add(strs[i]);
                for (int j = i + 1; j < strs.Length; j++)
                {
                    input = strs[i];
                    temp = strs[j];
                    bool found = true;

                    foreach (var c in input)
                    {
                        if (!temp.Contains(c))
                        {
                            found = false;
                        }
                    }
                    if (found)
                        subresult.Add(temp);
                }
                result.Add(subresult);
            }
            return result;

        }
    }
}
