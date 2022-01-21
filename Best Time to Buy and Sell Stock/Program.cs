public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = int.MinValue;
        for(int i = 0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                int sale = prices[j] - prices[i];
                if (sale > max)
                {
                    max = sale;
                }
            }
        }
        if(max > 0)
        {
            return max;
        }
        else
        {
            return 0;
        }
    }
}