public class Solution {
    public bool IsPalindrome(string s) 
    {

        char[] charArray = s.ToLower()
                            .Where(char.IsLetterOrDigit)
                            .ToArray();
        int i=0;

        int end = charArray.Length-1;

        while(i<end)
        {
            if( charArray[i]!= charArray[end])
            {
                return false;
            }
            i++;
            end--;
        }
        return true;
    }
}
