/*
//  https://leetcode.com/problems/contains-duplicate/
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tasks.Easy
{
    public class ContainsDuplicate
    {
        public ContainsDuplicate(int[] nums)
        {
            Console.WriteLine(ContainsDuplicates(nums));
        }
        
        private bool ContainsDuplicates(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            
            return nums.Length != hash.Count;
        }
    }
}