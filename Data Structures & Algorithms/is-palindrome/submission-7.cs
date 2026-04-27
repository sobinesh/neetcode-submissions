public class Solution {
    public bool IsPalindrome(string s) 
    {

        char[] tempArr = s.ToLower().ToCharArray();

        char[]charArray = tempArr.Where(x=>char.IsLetterOrDigit(x)).ToArray();
        int i=0;

        int end = charArray.Length-1;

        while(i<end)
        {
            if(i>=end)
              return true;

            if( charArray[i]!= charArray[end])
            {
                Console.WriteLine(i+""+charArray[i]+" "+end+" "+charArray[end]);
                return false;
            }
            i++;
            end--;
        }
        return true;
    }
}
