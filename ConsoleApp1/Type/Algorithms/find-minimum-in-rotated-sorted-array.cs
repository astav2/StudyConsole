using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    internal class find_minimum_in_rotated_sorted_array
    {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while(left<right)
            {
                if (nums[left] < nums[right]) return nums[left];
                int mid = left + (right - left) / 2;
                if(nums[mid]>nums[right])
                {
                    left = mid + 1;
                }
              
                else
                {
                    left++;
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
