using System;

namespace LeetCodePlayground
{
    public class LastWord
    {
        public int LengthOfLastWord(string s)
        {
            bool isOnlySpaces = true;
            foreach (var c in s)
            {
                if (c != ' ')
                {
                    isOnlySpaces = false;
                }
            }
            
            
            
            
            bool CheckEnding(string str)
        {
            bool endsWithSpace = false;
            int lastSpace = str.LastIndexOf(' ');
            if (lastSpace == str.Length - 1)
            {
                endsWithSpace = true;
            }

            return endsWithSpace;
        }

            
         string Trim(string str)
         {
             while (CheckEnding(str))
             {
                 str = str.Remove(str.Length - 1);
             }

             return str;
         }

         string tempStr = String.Empty;
         
         if (!isOnlySpaces)
         {
          tempStr = Trim(s);
         }


         int lastSpace1 = tempStr.LastIndexOf(' ');
        int result = tempStr.Length - lastSpace1 - 1;



            if (isOnlySpaces)
            {
                return 0;
            }
            else if (lastSpace1 == (-1))

            {
                return tempStr.Length;
            }
            else
            {
                return result;
            }
        }
    }
}