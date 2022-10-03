using System;
using System.Linq;

/*
//  https://leetcode.com/problems/validate-ip-address/
*/

namespace LeetCode.Tasks.Medium
{
    public class ValidateIPAdress
    {
        public string ValidIPAddress(string queryIP)
        {
            char[] goodChars = { 'a', 'b', 'c', 'd', 'e', 'f' , '0', '1',
            '2', '3', '4','5','6','7','8','9'};
            string[] IP;

            if (queryIP.Contains("."))
            {
                IP = queryIP.Split('.');

                if (IP.Length != 4) return "Neither";

                for (int i = 0; i < IP.Length; i++)
                {
                    var str = IP[i];
                    bool yes = int.TryParse(str, out int newStr);

                    if ((str.Length > 1 && str[0] == '0') || !yes || newStr > 255 || newStr < 0)
                        return "Neither";
                }

                return "IPv4";
            }

            else if (queryIP.Contains(":"))
            {
                IP = queryIP.Split(':');

                if (IP.Length != 8) return "Neither";

                for (int i = 0; i < IP.Length; i++)
                {
                    var str = IP[i].ToLower();

                    for (int j = 0; j < str.Length; j++)
                        if (!goodChars.Contains(str[j]))
                            return "Neither";

                    if (str.Length > 4 || str.Length < 1)
                        return "Neither";
                }

                return "IPv6";
            }

            return "Neither";
        }
    }
}
