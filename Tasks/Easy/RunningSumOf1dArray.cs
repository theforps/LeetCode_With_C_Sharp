using System;

namespace LeetCode.Tasks.Easy
{
    public class RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums)
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

        #region test cases
        static void Main(string[] args)
        {
            //will return [1,3,6,10]
            foreach (var x in RunningSum(new int[] { 1, 2, 3, 4 }))
                Console.WriteLine(x + " ");
            //will return 7
            Console.WriteLine(KthFactor(7, 2));
            //will return -1
            Console.WriteLine(KthFactor(4, 4));
        }
        #endregion
    }
}
