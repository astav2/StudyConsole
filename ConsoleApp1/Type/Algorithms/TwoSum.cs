using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    public class TwoSum2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> hashTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (hashTable.ContainsKey(compliment))
                {
                    return new int[] { hashTable[compliment], i };
                }
                else if (!hashTable.ContainsKey(nums[i]))
                {
                    hashTable.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}

/*
if (nums == null || nums.Length < 2)
    return new int[2];
Dictionary<int, int> dic = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    if (dic.ContainsKey(target - nums[i]))
        return new int[] { i, dic[target - nums[i]] };
    else if (!dic.ContainsKey(nums[i]))
        dic.Add(nums[i], i);
}
return new int[2];
*/