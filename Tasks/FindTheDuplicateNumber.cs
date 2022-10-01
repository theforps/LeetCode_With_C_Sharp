using System;

/*
//  https://leetcode.com/problems/find-the-duplicate-number/
*/

namespace LeetCode.Tasks
{
    public class FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
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

        #region test cases
        static void Main(string[] args)
        {
            //will return "blue is sky the"
            Console.WriteLine(ReverseWords("the sky is blue"));
            //will return "world hello"
            Console.WriteLine(ReverseWords("  hello world  "));
            //will return "example good a"
            Console.WriteLine(ReverseWords("a good   example"));
        }
        #endregion
    }
}
