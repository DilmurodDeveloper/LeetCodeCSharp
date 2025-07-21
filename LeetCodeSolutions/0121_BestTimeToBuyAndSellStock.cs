//- - - - - - - - - - - - - - - - - - - - - - - - -
// Best Time to Buy and Sell Stock - LeetCode #121
//- - - - - - - - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice)
                    minPrice = price;
                else if (price - minPrice > maxProfit)
                    maxProfit = price - minPrice;
            }

            return maxProfit;
        }
    }
}
