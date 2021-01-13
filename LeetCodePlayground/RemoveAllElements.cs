using System;

namespace LeetCodePlayground
{
    public class RemoveAllElements
    {
        public int RemoveElement(int[] nums, int val) {
            
            int maxElement = Int32.MaxValue;
            int maxElementsConvertedCount = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = maxElement;
                    maxElementsConvertedCount++;
                } 
            }
            
            Array.Sort(nums);
            Array.Resize(ref nums, nums.Length - maxElementsConvertedCount);
            
            return nums.Length;
        }
    }
}