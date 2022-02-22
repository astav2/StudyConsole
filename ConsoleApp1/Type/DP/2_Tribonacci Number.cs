using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
    public class Tribonacci_Number
    {
        public int Tribonacci(int n)
        {
            Dictionary<int, int> fibo = new Dictionary<int, int>();
            fibo[0] = 0; fibo[1] = 1;
            fibo[2] = 1;
            for(int i=3;i<=n;i++)
            {
                fibo[i] = fibo[i - 3] + fibo[i - 2] + fibo[i - 1];
            }
            return fibo[n];
        }
    }
}
