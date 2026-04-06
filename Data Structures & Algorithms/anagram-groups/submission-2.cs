public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string,List<string>> map = new();
        foreach(string s in strs)
        {
            char[] strArray = s.ToCharArray();
            Array.Sort(strArray);
            string key  = new string(strArray);
            if(map.TryGetValue(key,out var curList))
            {
                curList.Add(s);
                map[key]=curList;
            }
            else
            {
                map.Add(key,new List<string>{s});
            }
        }
        return new List<List<string>>(map.Values);
    }
}