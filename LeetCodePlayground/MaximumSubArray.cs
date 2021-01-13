using System.Collections.Generic;
using System.Linq;

namespace LeetCodePlayground
{
    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentFirstIndex = i;
                int tempSum = 0;
                for (int a = currentFirstIndex; a < nums.Length; a++)
                {
                    tempSum += nums[a];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
                
            }
            return maxSum;
        }
    }
}