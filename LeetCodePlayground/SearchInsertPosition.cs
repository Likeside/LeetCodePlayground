namespace LeetCodePlayground
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {

            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) result = i;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1] < target && nums[i] > target)
                {
                    result = i;
                }
            }

            if (target > nums[nums.Length - 1])
            {
                result = nums.Length;
            }

            return result;

        }
    }
}