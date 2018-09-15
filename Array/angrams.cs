using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    
    public class Angrams
    {
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        public IList<IList<string>> angrams1()
        {
            var found = new List<IList<string>>();
            var words = new Dictionary<int, string>();
            int count = 0;
            foreach (var item in strs)
            {
                words.Add(count, String.Concat(item.OrderBy(c=>c)));
                count++;
            }
            List<int> parsed = new List<int>();
            List<string> s = null;
            for(int i = 0; i<strs.Length; i++)
            {
                s = new List<string>();
                if (!parsed.Contains(i))
                {
                    parsed.Add(i);
                    s.Add(strs[i]);
                }
                else
                    continue;

                for (int j = i+1; j < strs.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        if (!parsed.Contains(j))
                        {
                            parsed.Add(j);
                            s.Add(strs[j]);
                        }
                    }
                }

                found.Add(s);
            }

            return found;

        }
    }
}
