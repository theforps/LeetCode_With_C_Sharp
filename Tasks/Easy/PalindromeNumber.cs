﻿using System;

/*
//  https://leetcode.com/problems/palindrome-number/
*/

// //will return true
// Console.WriteLine(IsPalindrome(121));
// //will return false
// Console.WriteLine(IsPalindrome(-121));
// //will return false
// Console.WriteLine(IsPalindrome(10));

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        string str = Convert.ToString(x);

        char[] chars = str.ToCharArray();

        Array.Reverse(chars);

        string newStr = new string(chars);

        if (newStr == str)
            return true;
        
        else
            return false;
    }
}
