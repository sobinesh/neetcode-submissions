public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, j - i));
            res.Add(s.Substring(j + 1, length));
            i = j + 1 + length;
        }
        return res;
    }
}