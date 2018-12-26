using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-medium/109/backtracking/793/
    /// https://www.geeksforgeeks.org/find-possible-words-phone-digits/
    /// </summary>
    public class LettersPhoneNumber
    {

        Dictionary<char, string> letters = new Dictionary<char, string>();
        
        public IList<string> LettersPhoneNumber1(string digits)
        {
            var list = new List<string>();
            letters.Add('0', "");
            letters.Add('1', "");
            letters.Add('2', "abc");
            letters.Add('3', "def");
            letters.Add('4', "ghi");
            letters.Add('5', "jkl");
            letters.Add('6', "mno");
            letters.Add('7', "pqrs");
            letters.Add('8', "tuv");
            letters.Add('9', "wxyz");

            foreach (var item in digits.ToList())
            {
                GetLetters(item, list);
            }
            return list;

        }

        public List<String> GetLetters(char c, List<String> list)
        {
            String s = letters[c];

            if (list.Count == 0)
            {
                foreach (var item in s.ToList())
                {
                    list.Add(item.ToString());
                }
                return list;
            }
            //Moving item from list of letters to temp and clearing it
            var temp = new List<String>();
            temp = list.Select(i => (String)i.Clone()).ToList();
            list.Clear();
            foreach (var item in s.ToList())
            {
                foreach (var l in temp)
                {
                    list.Add(l + item.ToString());
                }
            }

            return list;
        }
    }
}
