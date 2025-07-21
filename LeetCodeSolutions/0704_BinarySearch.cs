//- - - - - - - - - - - - - - - - 
// Binary Search - LeetCode #704
//- - - - - - - - - - - - - - - - 

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}
