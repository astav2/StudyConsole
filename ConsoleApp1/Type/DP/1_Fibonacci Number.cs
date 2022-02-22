using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
   public class Fibonacci_Number
    {
        public int Fib(int n)
        {
            Dictionary<int,int> fibo = new Dictionary<int, int>();
            fibo[0] = 0; fibo[1] = 1;

            for(int i=2;i<=n;i++)
            {               
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            return fibo[n];
        }
    }
}
