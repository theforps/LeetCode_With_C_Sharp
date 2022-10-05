using System;

/*
//  https://leetcode.com/problems/running-sum-of-1d-array/
*/

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
            //will return [1,2,3,4,5]
            foreach (var x in RunningSum(new int[] { 1, 1, 1, 1, 1 }))
                Console.WriteLine(x + " ");
            //will return [3,4,6,16,17]
            foreach (var x in RunningSum(new int[] { 3, 1, 2, 10, 1 }))
                Console.WriteLine(x + " ");
        }
        #endregion
    }
}
