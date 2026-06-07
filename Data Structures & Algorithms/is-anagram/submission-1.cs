public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> charNCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charNCount.ContainsKey(c))
            {
                charNCount[c]++;
            }
            else
            {
                charNCount[c] = 1;
            }
        }

        foreach (char c in t)
        {
            if (!charNCount.ContainsKey(c))
            {
                return false;
            }

            charNCount[c]--;

            if (charNCount[c] < 0)
            {
                return false;
            }
        }

        return true;
    }
}