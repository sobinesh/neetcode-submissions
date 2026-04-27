public class Solution {

    public string Encode(IList<string> strs) 
    {
        string encodedTxt = "";
        int last = strs.Count  - 1;

        if(last < 0)
          return "$_null_$";
        for(int i=0;i<strs.Count ;i++)
        {
            encodedTxt += strs[i];

            if(i != last)
                encodedTxt += "$_$_$";
        }

        return encodedTxt;
    }

    public List<string> Decode(string s) 
    {
        if(s=="$_null_$")
            return [];
            
        return s.Split("$_$_$").ToList();
    }
}
