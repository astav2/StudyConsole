using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    //https://leetcode.com/problems/koko-eating-bananas/
   internal class koko_eating_bananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1,
                right = piles.Max(),
                result = right;
            while(left<=right)
            {
                int mid = left + (right - left) / 2;
                var hours = 0;
                foreach(int pile in piles)
                {
                    hours += (int)Math.Ceiling((double)pile / mid);

                }
                if(hours<=h)
                {
                    result = Math.Min(result, mid);
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return result;
        }
    }
}
