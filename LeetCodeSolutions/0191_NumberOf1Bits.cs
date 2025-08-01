//- - - - - - - - - - - - - - - - -
// Number of 1 Bits - LeetCode #191
//- - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int HammingWeight(int n)
        {
            string binary = Convert.ToString(n, 2);
            int count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
