/*
//  https://leetcode.com/problems/sqrtx
*/


using System;

namespace LeetCode.Tasks.Easy
{
    public class Sqrt_x_
    {
        public Sqrt_x_(int x)
        {
            Console.WriteLine(MySqrt(x));
        }
        
        private int MySqrt(int x)
        {
            long result = 0;
            long multiply;
            long counter = x / 2 + 1;
            
            for (long i = 0; i <= counter; i++)
            {
                multiply = i * i;
                
                if (multiply <= x)
                {
                    result = i;
                }
                else
                {
                    break;
                }
            }

            return (int)result;
        }
    }
}