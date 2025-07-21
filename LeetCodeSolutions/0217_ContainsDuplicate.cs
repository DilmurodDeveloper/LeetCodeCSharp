//- - - - - - - - - - - - - - - - - -
// Contains Duplicate - LeetCode #217
//- - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);
            }

            return false;
        }
    }
}
