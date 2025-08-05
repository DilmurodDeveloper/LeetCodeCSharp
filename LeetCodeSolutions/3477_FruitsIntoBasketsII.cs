//- - - - - - - - - - - - - - - - - - - - -
// Fruits Into Baskets II - LeetCode #3477
//- - - - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            int n = fruits.Length;
            bool[] used = new bool[n];
            int unplacedCount = 0;

            for (int i = 0; i < n; i++)
            {
                bool placed = false;

                for (int j = 0; j < n; j++)
                {
                    if (!used[j] && baskets[j] >= fruits[i])
                    {
                        used[j] = true;
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    unplacedCount++;
                }
            }

            return unplacedCount;
        }
    }
}
