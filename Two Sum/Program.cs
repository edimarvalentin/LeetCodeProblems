public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int h = i + 1; h < nums.Length; h++)
            {
                if(nums[i] + nums[h] == target)
                {
                    int[] result = new int[2];
                    result[0] = i;
                    result[1] = h;
                    return result;
                }
            }
        }
        return null;
    }
}






class Program
{
    public static void Main(string[] args)
    {
        int[] TestCases = new int[] { 2, 7, 11, 15 };
        int Target = 9;
        Solution Test = new Solution();
        Test.TwoSum(TestCases, Target);
   
    }
}
