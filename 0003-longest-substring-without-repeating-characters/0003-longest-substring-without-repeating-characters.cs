public class Solution {
    public int LengthOfLongestSubstring(string text) {
        if (string.IsNullOrEmpty(text))
            return 0;

        int maxLength = 0;
        int start = 0;
        var charIndices = new Dictionary<char, int>();

        for (int end = 0; end < text.Length; end++)
        {
            if (charIndices.ContainsKey(text[end]) && charIndices[text[end]] >= start)
            {
                start = charIndices[text[end]] + 1;
            }
            
            charIndices[text[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}