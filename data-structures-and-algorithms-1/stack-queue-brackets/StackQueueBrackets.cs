using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.stack_queue_brackets
{
    public class StackQueueBrackets
    {
        public static bool IsBalanced(string text)
        {
            char[] splited = text.ToCharArray();

            Stack<char> stack1 = new Stack<char>();

            foreach (char c in splited)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stack1.Push(c);
                    continue;
                }

                char top = stack1.Peek();

                switch (c)
                {
                    case '}':
                        if (top == '{')
                            stack1.Pop();
                        else
                            return false;
                        break;

                    case ')':
                        if (top == '(')
                            stack1.Pop();
                        else
                            return false;
                        break;

                    case ']':
                        if (top == '[')
                            stack1.Pop();
                        else
                            return false;
                        break;
                }
            }

            return true;
        }
    }
}
