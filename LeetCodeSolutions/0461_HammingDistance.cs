//- - - - - - - - - - - - - - - - -
// Hamming Distance - LeetCode #461
//- - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            int distance = 0;

            while (xor != 0)
            {
                distance += xor & 1;
                xor >>= 1;
            }

            return distance;
        }
    }
