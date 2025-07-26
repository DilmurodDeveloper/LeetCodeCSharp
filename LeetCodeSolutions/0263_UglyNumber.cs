//- - - - - - - - - - - - - - -
// Ugly Number - LeetCode #263
//- - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public bool IsUgly(int number)
        {
            if (number <= 0) return false;

            int[] divisors = { 2, 3, 5 };

            foreach (int divisor in divisors)
            {
                while (number % divisor == 0)
                {
                    number /= divisor;
                }
            }

            return number == 1;
        }
    }
}
