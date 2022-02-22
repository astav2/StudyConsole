using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DS
{
    internal class ContainsNearbyAlmostDuplicate2
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= i + k &&j<nums.Length; j++)
                {
                    long diff = Math.Abs(nums[i] - nums[j]);
                    if ( diff<= t)
                        return true;
                }
            }
            return false;
        }

    }
}
