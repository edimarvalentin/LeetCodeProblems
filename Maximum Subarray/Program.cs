public class Solution
{
    public int MaxSubArray(int[] nums)
    {
      int n = nums.Length;
      int localMax = 0;
      int globalMax = int.MinValue;

      for (int i = 0; i < n; i++)
        {
            localMax = Math.Max(nums[i], nums[i] + localMax);
            if(localMax > globalMax)
            {
                globalMax = localMax;
            }
        }
        return globalMax;
    }
}