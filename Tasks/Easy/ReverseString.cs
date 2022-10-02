using System;

/*
//  https://leetcode.com/problems/reverse-string/
*/

public class ReverseString
{
    public static char[] ReverseStringOne(char[] s)
    {
        Array.Reverse(s);
        return s;
    }

    #region test cases
    static void Main(string[] args)
    {
        //will return "o","l","l","e","h"
        Console.WriteLine(ReverseStringOne(new char[] { 'h', 'e', 'l', 'l', 'o' }));
        //will return "h","a","n","n","a","H"
        Console.WriteLine(ReverseStringOne(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }));
    }
    #endregion
}
