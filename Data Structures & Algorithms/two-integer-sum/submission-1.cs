public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int firstNum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            firstNum = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (firstNum + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { };
    }
}