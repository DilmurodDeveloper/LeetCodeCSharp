//- - - - - - - - - - - - - - - - - - -
// Longest Common Prefix - LeetCode #14
//- - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            Array.Sort(strs);
            string first = strs[0];
            string last = strs[^1];
            int i = 0;

            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }
    }
}
