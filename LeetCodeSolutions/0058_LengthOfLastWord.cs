//- - - - - - - - - - - - - - - - - -
// Length of Last Word - LeetCode #58
//- - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public int LengthOfLastWord(string s)
        {
            List<string> words =
                s.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            return words[words.Count - 1].Length;
        }
    }
}
