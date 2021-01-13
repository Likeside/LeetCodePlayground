using System;

namespace LeetCodePlayground
{
    public class RemoveDuplicatesSort
    {
        public int RemoveDuplicates(int[] nums)
        {
            int maxElement = Int32.MaxValue;
            int maxElementsConvertedCount = 0;
            int maxElementsTotal = 0;
         
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    nums[i-1] = maxElement;
                    maxElementsConvertedCount++;
                } 
            }
            
            Array.Sort(nums);
            
            foreach (var num in nums)
            {
                if (num == maxElement)
                {
                    maxElementsTotal++;
                } 
            }

            if (maxElementsTotal > maxElementsConvertedCount)
            {
                Array.Resize(ref nums, nums.Length - (maxElementsTotal+1));
            }
            else
            {
                Array.Resize(ref nums, nums.Length - maxElementsTotal);
            }
            
            
            return nums.Length;
        }
    }
}