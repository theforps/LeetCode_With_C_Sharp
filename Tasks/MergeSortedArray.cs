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

    #region test cases
    static void Main(string[] args)
    {
        //will return [1,2,2,3,5,6]
        foreach (var x in Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3))
            Console.WriteLine(x + " ");
    }
    #endregion
}

