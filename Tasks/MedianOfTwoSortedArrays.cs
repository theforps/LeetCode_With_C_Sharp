using System;
using System.Collections.Generic;

/*
//  https://leetcode.com/problems/median-of-two-sorted-arrays/
*/

public class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int median = 0;

        var nums = new List<double> { };

        if (nums1.Length > 0) foreach (var x in nums1) nums.Add(x);
        if (nums2.Length > 0) foreach (var x in nums2) nums.Add(x);

        nums.Sort();

        if (nums.Count == 0) return 0;

        else if (nums.Count % 2 == 1)
        {
            median = (nums.Count - 1) / 2;
            return nums[median];
        }

        else
        {
            double dubMedian = 0;
            dubMedian = ((nums[nums.Count / 2] + nums[(nums.Count / 2) - 1]) / 2);
            return dubMedian;
        }
    }

    #region test cases
    static void Main(string[] args)
    {
        //will return 2
        Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
        //will return 2.5
        Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
        //will return 5
        Console.WriteLine(FindMedianSortedArrays(new int[] { 5 }, new int[] { }));
    }
    #endregion
}
