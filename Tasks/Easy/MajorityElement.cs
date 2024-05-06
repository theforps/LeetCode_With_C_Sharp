/*
//  https://leetcode.com/problems/majority-element/
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tasks.Easy
{
    public class MajorityElement
    {
        public MajorityElement(int[] nums)
        {
            Console.WriteLine(MajorityElement_(nums));
        }
        
        private int MajorityElement_(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);

            foreach (var x in hashSet)
            {
                int count = nums.Where(j => j == x).Count();
                
                if (nums.Length / 2 < count)
                {
                    return x;
                }
            }
            
            
            return 0;
        }
    }
}