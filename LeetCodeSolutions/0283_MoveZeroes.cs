//- - - - - - - - - - - - - - -
// Move Zeroes - LeetCode #283
//- - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int insertIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            }

            while (insertIndex < nums.Length)
            {
                nums[insertIndex] = 0;
                insertIndex++;
            }
        }
    }
}
