public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        long totalProduct = 1;
        long zeroTotal = 1;
        int n = 0;

        foreach(int i in nums)
        {
            totalProduct *= i;
            if(i!=0)
            {
                zeroTotal *= i;
            }
            else
            {
                n++;
            }
        }

        if(n>1)
           return new int[nums.Length];
           
        for(int i=0; i<nums.Length;i++)
        {
            int num = nums[i];
            if(num!=0)
            {
                if(totalProduct != 0)
                {
                    nums[i] = (int) totalProduct/num; 
                }
                else
                {
                     nums[i]=0;
                }
            }
            else
            {
                nums[i] = (int)zeroTotal;
            }
        }

        return nums;
        
    }
}
