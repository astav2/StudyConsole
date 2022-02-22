using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.DS
{
   internal class ContainsDuplicate2
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> inputCollection = new Dictionary<int, int>();
           for(int i=0;i<nums.Length; i++)
            {
                if (inputCollection.ContainsKey(nums[i]))
                    return true;
                inputCollection.Add(nums[i], i);
            }
            return false;
        }
    }
}
