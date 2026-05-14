public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int max = 0;
        int min = prices[0];

        foreach(int i in prices)
        {
            max = Math.Max(max,i-min);
            min = Math.Min(i,min);
        }

        return max;
    }
}
