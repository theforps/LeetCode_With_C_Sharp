/*
//  https://leetcode.com/problems/longest-common-prefix
*/


using System;

namespace LeetCode.Tasks.Easy
{
    public class LongestCommonPrefix {
        
        public LongestCommonPrefix(string[] strs)
        {
            Console.WriteLine(LongestPrefix(strs));
        }
        
        public string LongestPrefix(string[] strs)
        {
            bool flag = false;
            string result = "";

            Array.Sort(strs);

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (strs[0].Length > 0)
                {
                    result = strs[0].Substring(0, result.Length + 1);

                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (!strs[j].Substring(0, result.Length).Equals(result))
                        {
                            result = result.Substring(0, result.Length - 1);
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                        break;
                }
            }
            
            return result;
        }
    }
}