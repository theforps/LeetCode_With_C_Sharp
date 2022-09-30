using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tasks
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            string[] strArray = s.Split(' ');

            s = "";

            for (int i = strArray.Length - 1; i > -1; i--)
                if (strArray[i] != "")
                    s += strArray[i] + " ";

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
