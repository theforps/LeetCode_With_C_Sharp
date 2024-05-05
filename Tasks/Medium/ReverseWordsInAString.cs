﻿using System;

/*
//  https://leetcode.com/problems/reverse-words-in-a-string/description/
*/

// //will return "blue is sky the"
// Console.WriteLine(ReverseWords("the sky is blue"));
// //will return "world hello"
// Console.WriteLine(ReverseWords("  hello world  "));
// //will return "example good a"
// Console.WriteLine(ReverseWords("a good   example"));

namespace LeetCode.Tasks
{
    public class ReverseWordsInAString
    {
        public static string ReverseWords(string s)
        {
            string[] strArray = s.Split(' ');
            s = "";

            for (int i = strArray.Length - 1; i > -1; i--)
                if (strArray[i] != "")
                    s += strArray[i] + " ";

            s = s.Trim();

            return s;
        }

    }
}
