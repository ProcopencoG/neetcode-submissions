public class Solution {
    public bool IsPalindrome(string s) {
        string control = "";
        foreach (char c in s.ToLower()){
            if (Char.IsLetterOrDigit(c)){
                    control += c;
            }
        }
        char[] res = control.ToCharArray();
        char[] compare = control.ToCharArray();
        Array.Reverse(compare);

        return res.SequenceEqual(compare);
        
    }
}
