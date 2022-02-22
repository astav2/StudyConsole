using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DS
{
   internal class ContainsNearbyDuplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, List<int>> inputCollection = new Dictionary<int, List<int>>();
            bool result = false;
            for(int i = 0; i<nums.Length;i++ )
            {
                if (inputCollection.ContainsKey(nums[i]) && !result)
                {
                    var temp = inputCollection[nums[i]];
                    temp.Add(i);
                    if ((getMathAbs(temp) <= k))
                        return true;
                    else
                        result= false;
                }
                else
                {
                    inputCollection.Add(nums[i], new List<int>() { i });
                }
            }
            return false;
        }     

        private int getMathAbs(List<int> temp)
        {
            return Math.Abs(temp[temp.Count - 2] - temp[temp.Count - 1]);
        }
    }
}
