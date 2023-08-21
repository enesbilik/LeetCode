public class Solution
{
    public int SingleNumber(int[] nums)
    {

        return new HashSet<int>(nums).Sum() * 2 - nums.Sum();

    }
}