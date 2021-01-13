using System;

namespace LeetCodePlayground
{
    public class AddOne
    {
        public int[] PlusOne(int[] digits)
        {
            int nines = CountNinesInTheEnd(digits);

            if (nines == 0)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

            if (nines == digits.Length)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
                for (int i = 1; i < digits.Length; i++)
                {
                    digits[i] = 0;
                }

                return digits;
            }

            if (nines > 0 && nines < digits.Length)
            {
                int onePosition = digits.Length -1 - nines;
                digits[onePosition] += 1; 
                for (int i = digits.Length - 1; i > onePosition; i--)
                {
                    digits[i] = 0;
                }

                return digits;
            }




            return null;
        }

        //Проверяем конкретный элемент на 9-ку
        bool CheckForNine(int[] arrToCheck, int index)
        {
            if (arrToCheck[index] == 9)
            {
                return true;
            }

            else return false;
        }


        //Считаем количество девяток в конце массива
        int CountNinesInTheEnd(int[] arrToCount)
        {
            int countedNines = 0;
            for (int i = arrToCount.Length - 1; i >= 0; i--)
            {
                if (CheckForNine(arrToCount, i))
                {
                    countedNines++;
                }
                else break;
            }


            return countedNines;
        }
            
        
    }
}