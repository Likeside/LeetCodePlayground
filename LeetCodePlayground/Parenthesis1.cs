using System.Collections.Generic;

namespace LeetCodePlayground
{
    public class Parenthesis1
    {

        public bool CheckTwoBrackets(char first, char second)
        {
            bool flag = false;
            
            if ((first == '(') && (second == ')'))
            {
               flag = true;
            }
            if ((first == '{') && (second == '}'))
            {
                flag = true;
            }
            if ((first == '[') && (second == ']'))
            {
                flag = true;
            }

            return flag;

        }
        
        public bool IsValid(string s)
        {
            char[] charArray = s.ToCharArray();

            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charStack.Count <= 0)
                {
                    charStack.Push(charArray[i]);
                }
                else
                {

                    char previousChar = charStack.Peek();
                    if (CheckTwoBrackets(previousChar, charArray[i]))
                    {
                        charStack.Pop();
                    }
                    else
                    {
                        charStack.Push(charArray[i]);
                    }
                }
            }

            if (charStack.Count == 0)
            {
                return true;
            }
            else return false;
        }
    }
}