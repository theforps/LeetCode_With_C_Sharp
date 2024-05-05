using System;

/*
//  https://leetcode.com/problems/move-zeroes/
*/

//will return [1,3,12,0,0]
// foreach (var x in MoveZeroes(new int[] { 0, 1, 0, 3, 12 }))
//     Console.WriteLine(x + " ");

public class moveZeroes
{
    public static int[] MoveZeroes(int[] nums)
    {
        if (nums.Length != 1)
            for (int j = 0; j < nums.Length; j++)
                for (int i = 1; i < nums.Length; i++)
                {
                    int alert = 0;
                    if (nums[i - 1] == 0)
                    {
                        alert = nums[i];
                        nums[i] = 0;
                        nums[i - 1] = alert;
                    }
                }

        return nums;
    }
}

