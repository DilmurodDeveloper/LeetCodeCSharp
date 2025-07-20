//- - - - - - - - - - - - - - - - -
// Roman to Integer - LeetCode #13
//- - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int RomanToInt(string s)
        {
            var values = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && values[s[i]] < values[s[i + 1]])
                {
                    total -= values[s[i]];
                }
                else
                {
                    total += values[s[i]];
                }
            }
            return total;
        }
    }
}
