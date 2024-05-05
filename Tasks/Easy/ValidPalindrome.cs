using System;

/*
//  https://leetcode.com/problems/valid-palindrome/
*/

// //will return true
// Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
// //will return false
// Console.WriteLine(IsPalindrome("race a car"));
// //will return true
// Console.WriteLine(IsPalindrome(" "));

public class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        char[] symbols = { ',', '.', ':', ' ', '/', '#', '_', '-', '?',
            '!', ';', ')', '(', '`', '"', '[', ']', '@', '\'', '{', '}' };

        for (int i = 0; i < symbols.Length; i++)
            if (s.Contains(symbols[i].ToString()))
                s = s.Replace($"{symbols[i]}", "");

        s = s.ToLower();

        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        string str2 = new string(chars);


        if (s == str2) return true;
        else return false;
    }
}
