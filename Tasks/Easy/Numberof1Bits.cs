/*
//  https://leetcode.com/problems/number-of-1-bits
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tasks.Easy
{
    public class Numberof1Bits
    {
        public Numberof1Bits(int n)
        {
            Console.WriteLine(HammingWeight(n));
        }
        
        public int HammingWeight(int n)
        {
            int counter = 0;
            
            while (n != 0)
            {
                if (n == 1)
                {
                    counter += 1;
                    break;
                }

                if (n % 2 == 1)
                {
                    counter += 1;
                    n -= 1;
                }
                n /= 2;
            }

            return counter;
        }
    }
}