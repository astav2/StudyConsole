using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DP
{
    class HouseRobber
    {
        public int Rob(int[] nums)
        {
            //[1,2,3,1]
            int L = nums.Length;
            if (L == 1) return nums[0];
            if (L == 2) return Math.Max(nums[0], nums[1]);
            nums[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < L; i++)
            {
                nums[i] = Math.Max(nums[i - 1], nums[i - 2] + nums[i]);
            }
            return nums[L - 1];
        }
    }
}