using System.Linq;
//https://leetcode.com/problems/single-element-in-a-sorted-array/
namespace ConsoleApp1.Type.Algorithms
{
    internal class single_element_in_a_sorted_array
    {
        public int SingleNonDuplicate(int[] nums)
        {
            var result = nums.GroupBy(x => x).OrderBy(g => g.Count()).Select(y => new { y.Key }).ToArray();
            return result[0].Key;
        }
        public int SingleNonDuplicate_BinarySearch(int[] a)
        {
            int low = 0, high = a.Count() - 1;
            //Check if the unique element is at the boundary
            if (high == 0) return a[high];
            if (a[low] != a[low + 1]) return a[low];
            if (a[high] != a[high - 1]) return a[high];

            //Search
            while (low <= high)
            {
                int mid = low + ((high - low) >> 1);
                if (a[mid] != a[mid - 1] && a[mid] != a[mid + 1]) return a[mid];

                //if mid index is odd and prev element is same as mid element or mid index is even and next element is same as mid element, it means the order has not yet been disrupted, so search in right half
                if (((mid % 2 == 1) && a[mid - 1] == a[mid]) || ((mid % 2 == 0) && a[mid] == a[mid + 1]))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
