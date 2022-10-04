using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tasks.Medium
{
    public class TheKthFactorOfn
    {
        public int KthFactor(int n, int k)
        {
            var list = new List<int>();

            if (n >= k)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (n % i == 0)
                        list.Add(i);
                }
                if (list.Count >= k) return list[k - 1];
            }
            return -1;
        }
    }
}
