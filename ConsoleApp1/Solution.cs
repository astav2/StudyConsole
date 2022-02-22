using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {

            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                if (nums[start] == val)
                {
                    nums[start] = nums[end];
                    end--;
                }
                else
                    start++;
            }
            return start;

        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode result = new ListNode(0);
            var cur = result;
            while (head != null)
            {
                if (head.val != val)
                {

                    cur.next = head;
                    cur = cur.next;
                }
            }
            cur.next = null;
            return result.next;

        }

        public bool IsValid(string s)
        {
            var x = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            //Dictionary<char, char> dictionary = new Dictionary<char, char>();
            //dictionary.Add(')', '(');
            //dictionary.Add('}', '{');
            //dictionary.Add(']', '[');
            foreach (char c in x)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else if (stack.Count == 0) return false;
                else
                {
                    switch (c)
                    {
                        case ']':
                            if (stack.Peek() == '[')
                                stack.Pop();
                            else return false; break;
                        case '}':
                            if (stack.Peek() == '{')
                                stack.Pop();
                            else return false; break;
                        case ')':
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else return false; break;
                        default:
                            return false;
                    }
                    //if (stack.Count > 0 && stack.Peek() == dictionary[c])
                    //    stack.Pop();
                    //else
                    //{
                    //    return false;
                    //}
                }

            }
            return stack.Count == 0;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        //public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        //{

        //}
        public int ThreeSumClosest(int[] nums, int target)
        {

            Array.Sort(nums);
            int closest = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(sum - target) < Math.Abs(closest - target))
                    {
                        closest = sum;
                    }
                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return closest;

        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;
            for (int i = 0; i <= n; i++)
            {
                first = first.next;
            }
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy.next;

        }
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            if (nums.Length < 4) return result;

            for(int i=0;i<nums.Length-3;i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for(int j=i+1;j<nums.Length-2;j++)
                {
                    if (j > i+1 && nums[j] == nums[j - 1]) continue;
                    int left = j + 1;
                    int right = nums.Length - 1;

                    while(left<right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];

                        if(sum== target)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;

                            while (left < right && nums[left] == nums[left - 1]) left++;
                            while (left < right && nums[right] == nums[right + 1]) right--;
                        }
                        else if( sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }


            return result;




        }
            public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new string[0];

            IDictionary<int, string[]> letterSetup = new Dictionary<int, string[]>();
            letterSetup.Add(2, new string[] { "a", "b", "c" });
            letterSetup.Add(3, new string[] { "d", "e", "f" });
            letterSetup.Add(4, new string[] { "g", "h", "i" });
            letterSetup.Add(5, new string[] { "j", "k", "l" });
            letterSetup.Add(6, new string[] { "m", "n", "o" });
            letterSetup.Add(7, new string[] { "p", "q", "r", "s" });
            letterSetup.Add(8, new string[] { "t", "u", "v" });
            letterSetup.Add(9, new string[] { "w", "x", "y", "z" });
            int[] digitInput = digits.Select(x => Convert.ToInt32(x) - '0').ToArray();
            int first = digitInput[0];
            if (digitInput.Length == 1)
                return letterSetup[first].ToList();
            var result = new List<string>();
            result.AddRange(letterSetup[first]);
            for (int i = 0; i < digitInput.Length - 1; i++)
            {
                combine(out result, result.ToArray(), letterSetup[digitInput[i + 1]]);
            }
            return result;
        }

        void combine(out List<string> result, string[] first, string[] second)
        {
            result = new List<string>();
            foreach (string a in first)
            {
                foreach (string b in second)
                {
                    result.Add(string.Concat(a, b));
                }
            }

        }

    }
}
