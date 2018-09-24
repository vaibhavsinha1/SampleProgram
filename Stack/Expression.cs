using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Expression
    {
        char[] exp = { '{', '(', '}', '}' };
        public bool IsParenthesisBalanced()
        {
            bool balanced = true;
            var stack = new Stack();
            foreach (var item in exp)
            {
                if(item == '{' || item == '(' || item == '[')
                {
                    stack.Push(item);
                }
                else if(item == '}' || item == ')' || item == ']')
                {
                    if (stack.IsEmpty())
                    {
                        balanced = false;
                    }
                    else if (!isMatching(stack.pop(), item))
                    {
                        balanced = false;
                    }
                }
            }
            return balanced;
        }

        public bool isMatching(char char1, char char2)
        {
            bool isMatchingPair = false;
            if (char1 == '(' && char2 == ')')
                isMatchingPair = true;
            else if (char1 == '{' && char2 == '}')
                isMatchingPair = true;
            else if (char1 == '[' && char2 == ']')
                isMatchingPair = true;
            else
                isMatchingPair = false;

            return isMatchingPair;

        }
    }

    public class Stack
    {
        char[] items = new char[100];
        int top = -1;

        public String Push(char c)
        {
            if (top >= 99)
            {
                return "Stack is full";
            }
            else
            {
                top++;
                items[top] = c;
                return "Item added";
            }
        }

        public Char pop()
        {
            Char c = 'a';
            if(top == -1)
            {
                Console.WriteLine("Stack Empty");
            }
            else
            {

                c= items[top];
                top--;
            }
            return c;
        }

        public bool IsEmpty()
        {
           return  top == -1?true:false;
        }
    }


}
