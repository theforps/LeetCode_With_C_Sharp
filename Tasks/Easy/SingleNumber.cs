using System;

/*
//  https://leetcode.com/problems/single-number/
*/

public class SingleNumber
{
    public static int SingleNumberOne(int[] nums)
    {
        int alert = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            alert = 0;

            for (int j = 0; j < nums.Length; j++)
                if (nums[i] == nums[j])
                    alert++;
                
            if (alert == 1)
                return nums[i];
        }

        return 0;
    }

    #region test cases
    static void Main(string[] args)
    {
        //will return 1
        Console.WriteLine(SingleNumberOne(new int[]{ 2, 2, 1 }));
        //will return 4
        Console.WriteLine(SingleNumberOne(new int[] { 4, 1, 2, 1, 2 }));
        //will return 1
        Console.WriteLine(SingleNumberOne(new int[] { 1 }));
    }
    #endregion
}
