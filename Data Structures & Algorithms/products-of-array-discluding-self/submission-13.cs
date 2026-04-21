public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int totalProduct = 1;
        int n = 0;

        foreach(int i in nums)
        {
            if(i!=0)
            {
                totalProduct *= i;
                continue;
            }
            n++;
        }

        if(n>1)
           return new int[nums.Length];
           
        for(int i=0; i<nums.Length;i++)
        {
            int num = nums[i];
            if(num!=0)
            {
                if(n > 0)
                {
                    nums[i]=0;
                    continue;
                }

                nums[i] = totalProduct/num; 
            }
            else
            {
                nums[i] = totalProduct;
            }
        }

        return nums;
        
    }
}
