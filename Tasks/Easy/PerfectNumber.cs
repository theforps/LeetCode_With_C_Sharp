using System;

/*
//  https://leetcode.com/problems/perfect-number/
*/

// //will return true
// Console.WriteLine(CheckPerfectNumber(28));
// //will return false
// Console.WriteLine(CheckPerfectNumber(7));

namespace LeetCode.Tasks.Easy
{
    public class PerfectNumber
    {
        public static bool CheckPerfectNumber(int num)
        {
            decimal divisor = 1;

            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    divisor += i;

            Console.WriteLine(divisor);

            if (num / divisor == 1 && num != 1) return true;
            else return false;
        }
    }
}
