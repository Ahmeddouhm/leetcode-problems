public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(s[i]);
                break;

                case ')':
                    if (stack.Count == 0 || stack.Peek() != '(')
                        return false;

                    stack.Pop();
                break;

                case ']':
                    if (stack.Count == 0 || stack.Peek() != '[')
                        return false;

                    stack.Pop();
                break;
                case '}':
                    if (stack.Count == 0 || stack.Peek() != '{')
                        return false;

                    stack.Pop();
                break;
            }

        }
        return stack.Count == 0;;
    }
}