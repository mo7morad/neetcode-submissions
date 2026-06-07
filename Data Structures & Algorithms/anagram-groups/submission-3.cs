public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> values = new List<List<string>>();
        
        for (int i = 0; i < strs.Length; i++) {
            bool groupFound = false;
            
            for (int j = 0; j < values.Count; j++) {
                // compare against the first item in the group.
                if (IsAnagram(strs[i], values[j][0])) {
                    values[j].Add(strs[i]); // belongs here
                    groupFound = true;
                    break;
                }
            }
            
            if (!groupFound) {
                // no existing group matched — start a new one
                values.Add(new List<string> { strs[i] });
            }
        }
        
        return values;
    }

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        Dictionary<char, int> charNCount = new Dictionary<char, int>();
        
        foreach (char c in s) {
            if (charNCount.ContainsKey(c)) charNCount[c]++;
            else charNCount[c] = 1;
        }
        foreach (char c in t) {
            if (!charNCount.ContainsKey(c)) return false;
            charNCount[c]--;
            if (charNCount[c] < 0) return false;
        }
        return true;
    }
}