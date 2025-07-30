//- - - - - - - - - - - - - - - - -
// Valid Palindrome - LeetCode #125
//- - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !Char.IsLetterOrDigit(s[left])) left++;
                while (left < right && !Char.IsLetterOrDigit(s[right])) right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }

}
