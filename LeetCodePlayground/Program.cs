using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCodePlayground
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            #region ReverseNumber
            /*
            int Reverse(int x)
            {
                bool xNegative;

                if (x < 0)
                {
                    xNegative = true;
                }

                else xNegative = false;

                string xString = x.ToString();
                char[] charArray = xString.ToCharArray();
                Array.Reverse(charArray);
                if (xNegative)
                {
                    Array.Resize(ref charArray, charArray.Length - 1);
                }

                string resultString = new string(charArray);
                int resultNumber;
                bool parseResult = Int32.TryParse(resultString, out resultNumber);

                if (parseResult == false)
                {
                    return 0;
                }

                else
                {
                    int reversedInt = resultNumber;
                    

                        if (xNegative)
                        {
                            return -reversedInt;

                        }
                        else
                        {
                            return reversedInt;
                        }
                        
                }
            }

            int b = Reverse(-245);
            Console.WriteLine(b.ToString());
            Console.ReadLine();
            */
            #endregion
            
            #region Palindrome
/*
            bool IsPalindrome(int x)
            {
                bool isPal;
                List<bool> flagList = new List<bool>();

                if (x < 0)
                {
                    isPal = false;
                }
                else
                {
                    string xString = x.ToString();
                    char[] charArray = xString.ToCharArray();
                    
                        for (int i = 0; i <= charArray.Length / 2; i++)
                        {
                            bool flag;
                            if (charArray[i] == charArray[charArray.Length - 1 - i])
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                            }
                            flagList.Add(flag);
                        }

                        if (flagList.Contains(false))
                        {
                            isPal = false;
                        }
                        else
                        {
                            isPal = true;
                        }
                }
                
                

                return isPal;

            }

            bool iP = IsPalindrome(723327);
            Console.WriteLine(iP);
            Console.ReadLine();

*/

            #endregion

            #region RomanToInt
/*
            Console.WriteLine(RomanToInt.RomanToInt1("MCMXCIV"));
            Console.ReadLine();
*/
            #endregion

           //  Parenthesis1 p = new Parenthesis1();
           // Console.WriteLine(p.IsValid("[([]])[]"));
           // Console.WriteLine(p.IsValid("(){[]}(())"));
           // Console.ReadLine();
          // RemoveAllElements r = new RemoveAllElements();

          //int[] nums = new[] {-2,1,-3,4,-1,2,1,-5,4};

         // MaximumSubArray maximumSubArray = new MaximumSubArray();
         // int temp = maximumSubArray.MaxSubArray(nums);
        //  Console.WriteLine(temp);

       // LastWord lastWord = new LastWord();
      // int l = lastWord.LengthOfLastWord("a baaa    ");
      //  Console.WriteLine(l);


      AddOne addOne = new AddOne();
      int[] digits = new[] {9, 9, 9};
      
      Console.WriteLine(String.Join(" ", addOne.PlusOne(digits)));
      
          Console.ReadLine();

        }
    }
}