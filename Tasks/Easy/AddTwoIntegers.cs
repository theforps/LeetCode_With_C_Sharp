using System;

/*
//  https://leetcode.com/problems/add-two-integers/
*/

public class AddTwoIntegers
{
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    #region test cases
    static void Main(string[] args)
    {
        //will return 17
        Console.WriteLine(Sum( 12, 5 ));
        //will return -6
        Console.WriteLine(Sum( -10, 4 ));
    }
    #endregion
}
