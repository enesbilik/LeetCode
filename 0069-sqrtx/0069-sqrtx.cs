public class Solution {
    public int MySqrt(int x)
    {
        if (x == 0) return 0;
        var i = 1;
        for (; i <= x / i; i++)
            if (x / i == i)
                return i;
        return i - 1;
    }
}