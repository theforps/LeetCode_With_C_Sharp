using System;
using System.Collections.Generic;

/*
//  https://leetcode.com/problems/validate-ip-address/
*/

namespace LeetCode.Tasks.Medium
{
    public class TheKthFactorOfn
    {
        public int KthFactor(int n, int k)
        {
            var list = new List<int>();

            if (n >= k)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (n % i == 0)
                        list.Add(i);
                }
                if (list.Count >= k) return list[k - 1];
            }
            return -1;
        }

        #region test cases
        static void Main(string[] args)
        {
            //will return "IPv4"
            Console.WriteLine(ValidIPAddress("172.16.254.1"));
            //will return "IPv6"
            Console.WriteLine(ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334"));
            //will return "Neither"
            Console.WriteLine(ValidIPAddress("256.256.256.256"));
        }
        #endregion
    }
}
