public class Solution {
    public string LongestPalindrome(string text) {
        if (text.Length < 1) {
            return "";
        }

        var start = 0;
        var end = 0;

        for (var i = 0; i < text.Length; i++) {
            var len1 = ExpandAroundCenter(text, i, i); 
            var len2 = ExpandAroundCenter(text, i, i + 1);
            var maxLength = Math.Max(len1, len2);

            if (maxLength > end - start) {
                start = i - (maxLength - 1) / 2;
                end = i + maxLength / 2;
            }
        }

        return text.Substring(start, end - start + 1);
    }

    private int ExpandAroundCenter(string text, int left, int right) {
        while (left >= 0 && right < text.Length && text[left] == text[right]) {
            left--;
            right++;
        }
        return right - left - 1; 
    }
}