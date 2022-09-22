using System;
using System.Collections.Generic;

/*
//  https://leetcode.com/problems/roman-to-integer/
*/

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        int k = 0, j = 0, v = 0, x = 0, l = 0, c = 0, d = 0, m = 0, res = 0;
        var spisok = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I') { spisok.Add(1); j++; }
            if (s[i] == 'V') { spisok.Add(5); v++; }
            if (s[i] == 'X') { spisok.Add(10); x++; }
            if (s[i] == 'L') { spisok.Add(50); l++; }
            if (s[i] == 'C') { spisok.Add(100); c++; }
            if (s[i] == 'D') { spisok.Add(500); d++; }
            if (s[i] == 'M') { spisok.Add(1000); m++; }
        }

        for (int b = 0; b < 3; b++) spisok.Add(0);

        for (int i = 0; i < spisok.Count - 3; i++)
        {
            if (spisok[i] < spisok[i + 1]) res -= spisok[i];
            else res += spisok[i];
        }

        return res;
    }

    #region test cases
    static void Main(string[] args)
    {
        //will return 3
        Console.WriteLine(RomanToInt("III"));
        //will return 58
        Console.WriteLine(RomanToInt("LVIII"));
        //will return 1994
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }
    #endregion
}
