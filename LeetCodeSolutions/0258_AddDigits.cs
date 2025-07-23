//- - - - - - - - - - - - - -
// Add Digits - LeetCode #258
//- - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int AddDigits(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }

            return num;
        }
    }
}
