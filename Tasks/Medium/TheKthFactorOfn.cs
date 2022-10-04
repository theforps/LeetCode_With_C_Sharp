using System;
using System.Collections.Generic;

/*
//  https://leetcode.com/problems/the-kth-factor-of-n/
*/

namespace LeetCode.Tasks.Medium
{
    public class TheKthFactorOfn
    {
        public static int KthFactor(int n, int k)
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
            //will return 3
            Console.WriteLine(KthFactor( 12, 3 ));
            //will return 7
            Console.WriteLine(KthFactor( 7, 2 ));
            //will return -1
            Console.WriteLine(KthFactor( 4, 4 ));
        }
        #endregion
    }
}
