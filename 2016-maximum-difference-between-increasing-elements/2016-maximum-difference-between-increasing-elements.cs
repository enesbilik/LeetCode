public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        var maxVal = -1;
        for (var i = 0; i < nums.Length - 1; i++)
        for (var j = i + 1; j < nums.Length; j++)
            if (nums[j] != nums[i] && nums[j] - nums[i] > maxVal)
            {
                maxVal = nums[j] - nums[i];
            }

        return maxVal;
    }
}