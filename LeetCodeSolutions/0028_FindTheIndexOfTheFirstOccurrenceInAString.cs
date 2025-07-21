//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// Find the Index of the First Occurrence in a String - LeetCode #28
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                string sub = haystack.Substring(i, needle.Length);
                if (sub == needle)
                    return i;
            }

            return -1;
        }
    }
}
