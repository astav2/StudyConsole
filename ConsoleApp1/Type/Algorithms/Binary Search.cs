using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    public class Binary_Search
    {
      
       
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
                return (nums[0] == target) ? 0 : -1;
            int left = 0, right = nums.Length-1;
            while(left<=right)
            {
                int mean = Math.Abs((right+left) / 2);
                if (nums[mean] == target)
                    return mean;
                if(nums[mean]>target)
                {
                   
                    right = mean - 1;
                }
                else
                {
                    left = mean + 1;
                   
                }
            }
            return -1;
        }
    }
}
