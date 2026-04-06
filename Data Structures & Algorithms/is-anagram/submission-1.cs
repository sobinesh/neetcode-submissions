public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) return false;
        int[] sCharArray = new int[26];
        int[] tCharArray = new int[26];

       for( int i=0; i<s.Length; i++ )
       {
         sCharArray[s[i]-'a']++;
         tCharArray[t[i]-'a']++;
       };

       for( int j=0; j<26; j++)
       {
            if(sCharArray[j]!=tCharArray[j]) return false;
       };

       return true;
    }
}
