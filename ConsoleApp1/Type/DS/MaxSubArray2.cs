using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DS
{
    public class MaxSubArray2
    {
        public int MaxSubArray(int[] nums)
        {

            int currMax = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum < 0)
                    sum = 0;
                sum += nums[i];
                currMax = Math.Max(currMax, sum);
            }
            return currMax;

        }
    }
}
