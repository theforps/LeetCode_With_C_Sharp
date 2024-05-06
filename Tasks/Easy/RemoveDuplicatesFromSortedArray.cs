/*
//  https://leetcode.com/problems/remove-duplicates-from-sorted-array
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Tasks.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public RemoveDuplicatesFromSortedArray(int[] nums)
        {
            Console.WriteLine(RemoveDuplicates(nums));
        }
        
        public int RemoveDuplicates(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (var x in nums)
            {
                hashSet.Add(x);
            }

            int k = hashSet.Count;
            
            int[] expectedNums = hashSet.ToArray();
            
            for (int i = 0; i < k; i++) {
                nums[i] = expectedNums[i];
            }

            return k;
        }
    }
}