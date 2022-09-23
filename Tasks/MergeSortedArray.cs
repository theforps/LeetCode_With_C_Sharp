using System;

/*
//  https://leetcode.com/problems/merge-sorted-array/
*/

public class MergeSortedArray
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (int i = 0; i < nums2.Length; i++)
                nums1[i] = nums2[i];
        }
        else
        {
            for (int i = 0; i < nums2.Length; i++)
                nums1[i + m] = nums2[i];
        }

        Array.Sort(nums1);

        return nums1;
    }

}

