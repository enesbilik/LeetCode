public class Solution {
    public int LengthOfLongestSubstring(string text) {
        if (text.Length == 1) return 1;

        int count = 0;
        string s_result = string.Empty;

        foreach (char i in text)
        {
            if (!s_result.Contains(i))
            {
                s_result += i;
            }
            else
            {
                s_result = s_result.Substring(s_result.IndexOf(i) + 1) + i;
            }

            if (s_result.Length > count)
            {
                count = s_result.Length;
            }
        }

        return count;
    }
}