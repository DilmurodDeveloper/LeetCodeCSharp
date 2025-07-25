﻿//- - - - - - - - - - - - - - - - 
// Two Sum Solution - LeetCode #1
//- - - - - - - - - - - - - - - - 

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}