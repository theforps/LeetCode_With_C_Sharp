﻿using System;

/*
//  https://leetcode.com/problems/calculate-money-in-leetcode-bank/
*/

namespace LeetCode.Tasks.Easy
{
    public class CalculateMoneyInLeetcodeBank
    {
        public static int TotalMoney(int n)
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
            //will return 10
            Console.WriteLine(TotalMoney(4));
            //will return 37
            Console.WriteLine(TotalMoney(10));
            //will return 96
            Console.WriteLine(TotalMoney(20));
        }
        #endregion
    }
}
