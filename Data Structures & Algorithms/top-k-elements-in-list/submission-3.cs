public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> dict = new();
        foreach(int n in nums)
        {
            dict[n] = dict.GetValueOrDefault(n)+1;
        }

         return dict.OrderByDescending(x => x.Value)
                   .Take(k)
                   .Select(x => x.Key)
                   .ToArray();
    }
}
