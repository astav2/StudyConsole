using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
    public class MinCostClimbingStairsS
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            //1,100,1,1,1,100,1,1,100,1
            for (int i = cost.Length - 3; i >= 0; i--)
            {
                cost[i] = Math.Min(cost[i] +cost[i + 1], cost[i] +cost[i + 2]);

            }
            return Math.Min(cost[0], cost[1]);
        }
    }
}
