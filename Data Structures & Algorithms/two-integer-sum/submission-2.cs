public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> set = new();
        for(int i = 0; i<nums.Length; i++)
        {
            int num = nums[i];
            int value = target - num;
            if(set.ContainsKey(value)) 
            {
                return new int[] {set[value],i};
            }
            set[num]=i;
        }
        return new int[]{};
    }
}
