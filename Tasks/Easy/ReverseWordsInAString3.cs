using System;

/*
//  https://leetcode.com/problems/reverse-words-in-a-string-iii/
*/

namespace LeetCode.Tasks
{
    public class ReverseWordsInAString3
    {
        public static string ReverseWords(string s)
        {
            string[] strings = s.Split(' ');
            s = "";

            for (int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray();
                Array.Reverse(chars);
                strings[i] = new string(chars);
                s += strings[i] + " ";
            }

            s = s.Trim();

            return s;
        }

        #region test cases
        static void Main(string[] args)
        {
            //will return "s'teL ekat edoCteeL tsetnoc"
            Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
            //will return "doG gniD"
            Console.WriteLine(ReverseWords("God Ding"));
        }
        #endregion
    }
}
