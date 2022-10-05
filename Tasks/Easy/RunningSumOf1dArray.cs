namespace LeetCode.Tasks.Easy
{
    public class RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int result = 0;
            int[] ints = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result = 0;
                for (int j = 0; j < i + 1; j++)
                    result += nums[j];
                ints[i] = result;
            }
            return ints;
        }
    }
}
