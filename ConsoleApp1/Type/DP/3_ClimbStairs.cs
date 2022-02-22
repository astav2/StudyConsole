using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
    public class ClimbStairsS
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            Dictionary<int, int> ways = new Dictionary<int, int>();
            ways[1] = 1;
            ways[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[n];

            int one=1, two = 1;
            for(int i=0;i<n-1;i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }
            return one;
        }
    }
}
