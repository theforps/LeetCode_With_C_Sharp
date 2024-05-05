﻿using System;

/*
//  https://leetcode.com/problems/find-the-duplicate-number/
*/

// //will return 2
// Console.WriteLine(FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
// //will return 3
// Console.WriteLine(FindDuplicate(new int[] { 3, 1, 3, 4, 2 }));

namespace LeetCode.Tasks
{
    public class FindTheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            // variant 1
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
                if (nums[i] == nums[i - 1]) return nums[i];

            return 0;

            // variant 2
            /* 
            for (ushort i = 0; i < nums.Length; i++)
                for (ushort j = ushort.Parse((nums.Length-1).ToString()); j > 0; j--)
                    if (i != j && nums[i] == nums[j]) return nums[i];

            return 0;
            */
        }
    }
}
