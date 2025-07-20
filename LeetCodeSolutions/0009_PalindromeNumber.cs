//- - - - - - - - - - - - - - - - - - - - -
// Palindrome Number Solution - LeetCode #9
//- - - - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int original = x;
            int reverse = 0;

            while (x != 0)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return original == reverse;
        }
    }
}
