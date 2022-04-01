using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
    internal class Smallest_String_With_A_Given_Numeric_Value
    {
        public string GetSmallestString(int n, int k)
        {
            StringBuilder sb = new StringBuilder();
            string chars="abcdefghijklmnopqrstuvwxyz";
            while(n-- >0)
            {
                if(k-n>25)
                {
                    sb.Append("z");
                    k = k - 26;
                }
                else
                {
                    sb.Append(chars.ElementAt(k - n - 1));
                    k = k - (k - n);
                }
            }
            return sb.ToString().ToCharArray().Reverse().ToString();
        }
    }
}
