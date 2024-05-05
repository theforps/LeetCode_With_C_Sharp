using System;

/*
//  https://leetcode.com/problems/reverse-integer/
*/

// //will return 0
// Console.WriteLine(Reverse(1534236469));
// //will return 321
// Console.WriteLine(Reverse(123));
// //will return 21
// Console.WriteLine(Reverse(120));

public class ReverseInteger
{
    public static int Reverse(int x)
    {
        int g = 0;
        int k = 0;
        string b = "";

        if (x < 0)
        {
            x *= -1;
            g++;
        }
        string a = x.ToString();

        for (int i = a.Length - 1; i > -1; --i)
            b += a[i];
        
        var c = Convert.ToDecimal(b);

        if (c >= 2147483647 || c <= -2147483647) b = "0";

        k = Convert.ToInt32(b);

        if (g == 1 && b != "0") k *= -1;

        return k;
    }
}
