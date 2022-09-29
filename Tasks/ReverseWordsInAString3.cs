using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //will return "o","l","l","e","h"
            Console.WriteLine(ReverseStringOne(new char[] { 'h', 'e', 'l', 'l', 'o' }));
            //will return "h","a","n","n","a","H"
            Console.WriteLine(ReverseStringOne(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }));
        }
        #endregion
    }
}
