using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    //https://leetcode.com/problems/find-peak-element/
    internal class find_peak_element
    {
        public int FindPeakElement(int[] nums)
        {
            int target = 1;

            int left = 0, right = nums.Length - 1;
            if (nums.Length == 1)
                return 0;
            while (left <= right)
            {
                if (nums[left] > nums[target])
                    target = left;
                left++;
            }
            return target;
        }
    }
}
