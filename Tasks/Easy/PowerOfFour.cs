/*
//  https://leetcode.com/problems/power-of-four/submissions/
*/

using System;

namespace LeetCode.Tasks.Easy
{
    public class PowerOfFour
    {
        public PowerOfFour(int n)
        {
            Console.WriteLine(IsPowerOfFour(n));
        }
        
        public bool IsPowerOfFour(int n)
        {
            if (n == 1)
                return true;
            else if (n <= 0)
                return false;

            while (n != 1)
            {
                if (n % 4 > 0)
                    return false;

                n /= 4;
            }

            return true;
        }
    }
}