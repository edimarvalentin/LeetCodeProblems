public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int h = i + 1; h < nums.Length; h++)
            {
                if (nums[h] == nums[i])
                {
                    return true;
                }
            }
        }
        return false;  
    }
}