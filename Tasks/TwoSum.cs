using System;

/*
//  https://leetcode.com/problems/two-sum/
*/

namespace LeetCode.Tasks
{
    public class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 1; j < nums.Length; j++)
                    if ((nums[i] + nums[j]) == target && (i != j))
                        return new int[] { i, j };
            return null;
        }

        #region test cases
        static void Main(string[] args)
        {
            //will return [0,1]
            foreach (var x in twoSum(new int[] { 2, 7, 11, 15 }, 9))
                Console.Write(x + "");
            //will return [1,2]
            foreach (var x in twoSum(new int[] { 3, 2, 4 }, 6))
                Console.Write(x + "");
            //will return [0,1]
            foreach (var x in twoSum(new int[] { 2, 7, 11, 15 }, 9))
                Console.Write(x + "");
        }
        #endregion
    }
}
