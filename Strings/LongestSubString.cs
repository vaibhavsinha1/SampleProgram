using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    /// <summary>
    /// Longest Substring Without Repeating Characters
    /// Given a string, find the length of the longest substring without repeating characters. 
    /// For example, the longest substrings without repeating characters for “ABDEFGABEF” are “BDEFGA” and “DEFGAB”, with length 6. 
    /// For “BBBB” the longest substring is “B”, with length 1. For “GEEKSFORGEEKS”, there are two longest substrings shown in the below diagrams, with length 7.
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/solution/
    /// </summary>
    public class LongestSubString
    {
        String s = "dvdf";
        public int LongestSubString1()
        {
            if (String.IsNullOrEmpty(s))
                return 0;
           int max = 1;
            for (int i = 0; i < s.Length; i++)
            {

                for (int j = i+1; j <= s.Length; j++)
                {
                    if (AllUnique(s, i, j))
                        max = Math.Max(max, j - i);
                }
            }
            return max;
        }

        private bool AllUnique(String s, int start, int end)
        {
            HashSet<char> words = new HashSet<char>();
            bool isUnique = true;
            for (int i = start; i < end; i++)
            {
                if (!words.Contains(s.ElementAt(i)))
                    words.Add(s.ElementAt(i));
                else
                {
                    isUnique = false;
                    break;
                }

            }
            return isUnique;
        }

    }
}
