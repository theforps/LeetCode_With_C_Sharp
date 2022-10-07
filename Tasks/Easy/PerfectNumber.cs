using System;

namespace LeetCode.Tasks.Easy
{
    public class PerfectNumber
    {
        public bool CheckPerfectNumber(int num)
        {
            decimal divisor = 1;

            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    divisor += i;

            Console.WriteLine(divisor);

            if (num / divisor == 1 && num != 1) return true;
            else return false;
        }

        #region test cases
        static void Main(string[] args)
        {
            //will return true
            Console.WriteLine(IsPalindrome(121));
            //will return false
            Console.WriteLine(IsPalindrome(-121));
            //will return false
            Console.WriteLine(IsPalindrome(10));
        }
        #endregion
    }
}
