using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    internal class capacity_to_ship_packages_within_d_days
    {
        //https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
        public int ShipWithinDays(int[] weights, int days)
        {
            int left = weights.Max();
            int right = weights.Sum();
            while(left<right)
            {
                int mid = left + (right - left) / 2;
                if (can_ship(mid, weights, days))
                    right = mid;
                else
                    left = mid + 1;
            }
            return right;
        }

        private bool can_ship(int candidate, int[] weights, int days)
        {
            int current_weight = 0;
            int days_taken = 1;
            foreach(int weight in weights)
            {
                current_weight += weight;
               
                if(current_weight> candidate)
                {
                    days_taken += 1;
                    current_weight = weight;
                }
            }
            return days_taken <= days;
        }
    }
}
