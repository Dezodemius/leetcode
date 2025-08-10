namespace Tasks.Task1493;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        return new Tasks.Task1004.Solution().LongestOnes(nums, 1) - 1;
    }
}