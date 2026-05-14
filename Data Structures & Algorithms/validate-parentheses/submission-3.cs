public class Solution {
    public bool IsValid(string s) {
        Stack<char> input = new();
        foreach(char c in s.ToCharArray())
        {
            if(c=='('||c=='['||c=='{')
            {
                input.Push(c);
            }
            else
            {
                char compIn = (c==')') ? '(' : (c==']') ?'[':'{';
                if(input.Count == 0 || input.Pop()!=compIn)
                    return false;
            }
        }

        return input.Count == 0;
    }
}
