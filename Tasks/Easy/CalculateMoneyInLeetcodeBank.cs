using System;

/*
//  https://leetcode.com/problems/calculate-money-in-leetcode-bank/
*/

namespace LeetCode.Tasks.Easy
{
    public class CalculateMoneyInLeetcodeBank
    {
        public int TotalMoney(int n)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < n / 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    sum += nums[j];
                    nums[j] += 1;
                }

            for (int j = 0; j < n % 7; j++)
            {
                sum += nums[j];
                nums[j] += 1;
            }

            return sum;
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
