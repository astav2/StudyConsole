using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type
{
    internal class check_if_n_and_its_double_exist
    {
        //https://leetcode.com/problems/check-if-n-and-its-double-exist/
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            var result = false;
            foreach( int x in arr)
            {
                result = Search(arr, 2 * x);
                if (result)
                    return result;
            }
            return result;
        }
        public bool Search(int[] nums, int target)
        {
            if (nums.Length == 1)
                return false;
           if(target==0)
            {
                var grp = nums.ToList().GroupBy(i => i);
                var y = grp.Where(k => k.Key == 0);
                return y.FirstOrDefault().Count()% 2 == 0;
            }
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mean = Math.Abs((right + left) / 2);
                if (nums[mean] == target)
                    return true;
                if (nums[mean] > target)
                {

                    right = mean - 1;
                }
                else
                {
                    left = mean + 1;

                }
            }
            return false;
        }
    }
}
