//- - - - - - - - - - - - - - - - -
// Valid Parentheses - LeetCode #20
//- - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        public bool IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char currentChar in input)
            {
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    stack.Push(currentChar);
                }
                else
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Peek(), currentChar))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        private bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}
