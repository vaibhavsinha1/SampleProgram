using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ValidParentheses
    {
        //string s = "([])";

        public bool IsValidParantheses(String s)
        {
            var st = new Stack<String>();
            var brackets = new Dictionary<String, String>();
            brackets.Add(")", "(");
            brackets.Add("]", "[");
            brackets.Add("}", "{");
            Char strC; //= String.Empty;
            var openingList = brackets.SelectMany(f => f.Value).ToList();
            var closingList = brackets.SelectMany(f => f.Key).ToList();
            bool isValid = true;
            int i = 0;
            String popChar,brOpeningChar;
            while (i < s.Length)
            {
                strC = s.ElementAt(i);//.ToString();
                if(closingList.Contains(strC)) 
                {
                    if(st.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    popChar = st.Pop();
                    brOpeningChar = brackets[strC.ToString()];
                    if (popChar != brOpeningChar)//getting the corresonding opening bracket of the closing bracket, If the character matches , its a valid sub expression, else not 
                    {
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    st.Push(strC.ToString());
                }

                i++;
            }

            return isValid;
        }
    }
}
