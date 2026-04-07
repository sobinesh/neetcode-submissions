public class Solution {

    public string Encode(IList<string> strs) {
        string encode = "";
        foreach(string s in strs){
            encode += s.Length.ToString() + "£" + s + "¬";
        } 
       return encode;
    }

    public List<string> Decode(string s) {
        List<string> decode = new List<string>();
        for(int i = 0; i < s.Length;){
            while(s[i] != '£') i += 1;
            int start = i + 1;
            while(s[i] != '¬') i += 1;
            int end = i;
            string sub = s.Substring(start, end - start);
            decode.Add(sub);
            i += 1;
        }
        return decode;
   }
}
