using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InfixtoPostfix : SOperator
    {
        #region InfixtoPostfix_Evaluation
        public void postfix_evaluation(string postfix)
        {
            float result, op1, op2;
            Stack<float> stack = new Stack<float>();
            int len = (postfix.Length);
            for (int i = 0; i < len; i++)
            {
                if (postfix[i] == ' ')
                    continue;
                else if (char.IsDigit(postfix[i]))
                {
                    int num = 0;

                    while (char.IsDigit(postfix[i]))
                    {
                        num = num * 10 + (postfix[i] - '0');
                        i++;
                    }
                    i--;
                    stack.Push(num);
                }
                else
                {
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    switch (postfix[i])
                    {
                        case '+':
                            result = (float)(op2 + op1);
                            stack.Push(result);
                            break;
                        case '-':
                            result = (float)(op2 - op1);
                            stack.Push(result);
                            break;
                        case '*':
                            result = (float)(op2 * op1);
                            stack.Push(result);
                            break;
                        case '/':
                            result = (float)(op2 / op1);
                            stack.Push(result);
                            break;
                        case '^':
                            result = (float)(Math.Pow(op2, op1));
                            stack.Push(result);
                            break;
                    }
                }
            }
            result = (float)stack.Pop();
            Console.Write("\nAnswer:: " + result);
        }
        #endregion

        #region faltu
        //public void infix_postfix(char[] infix)
        //{
        //    int len, i, j = 0;
        //    char[] postfix = new char[100];
        //    Stack<char> stack = new Stack<char>();
        //    len = (infix.Length);
        //    infix[len - 1] = ')';
        //    stack.Push('(');
        //    for (i = 0; i < len; i++)
        //    {
        //        if (prec(infix[i]) == 0)
        //        {
        //            postfix[j] = infix[i];
        //            j++;
        //        }
        //        //else if (prec(infix[i]) == 0)
        //        //{
        //        //    postfix[j] = infix[i];
        //        //    j++;
        //        //}
        //        else if (prec(infix[i]) == 1)
        //        {
        //            stack.Push(infix[i]);
        //        }
        //        else if (prec(infix[i]) == 2)
        //        {
        //            char ch;
        //            ch = stack.Pop();
        //            while (ch != '(')
        //            {
        //                postfix[j] = ch;
        //                j++;
        //                ch = stack.Pop();
        //            }
        //        }
        //        else if (prec(infix[i]) == 3)
        //        {
        //            char ch;
        //            ch = stack.Pop();
        //            while (prec(ch) >= 3)
        //            {
        //                postfix[j] = ch;
        //                j++;
        //                ch = stack.Pop();
        //            }
        //            stack.Push(ch);
        //            stack.Push(infix[i]);
        //        }
        //        else if (prec(infix[i]) == 4)
        //        {
        //            char ch;
        //            ch = stack.Pop();
        //            while (prec(ch) >= 4)
        //            {
        //                postfix[j] = ch;
        //                j++;
        //                ch = stack.Pop();
        //            }
        //            stack.Push(ch);
        //            stack.Push(infix[i]);
        //        }
        //        else if (prec(infix[i]) == 5)
        //        {
        //            char ch;
        //            ch = stack.Pop();
        //            while (prec(ch) >= 5)
        //            {
        //                postfix[j] = ch;
        //                j++;
        //                ch = stack.Pop();
        //            }
        //            stack.Push(ch);
        //            stack.Push(infix[i]);
        //        }
        //        //displayp(p);
        //    }
        //    postfix[j] = '\0';
        //    Console.WriteLine("\n\nPOSTFIX EXPRESSION: ");
        //    for (i = 0; i < j; i++)
        //    {
        //        Console.Write(" " + postfix[i]);
        //    }
        //    //postfix_evaluation(postfix.ToString());
        //}
        #endregion

        #region InfixtoPostfix_Conversion
        public void infixToPostfix(string exp)
        {
            // initializing empty String for result 
            string result = "";

            // initializing empty stack 
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];


                // If the scanned character is an operand, add it to output. 
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                else if (char.IsDigit(exp[i]))
                {
                    int operand = 0;
                    while (i < exp.Length && char.IsDigit(exp[i]))
                    {
                        operand = (operand * 10) + (exp[i] - '0');
                        i++;
                    }
                    i--;
                    result = result + " " + operand.ToString();
                }

                // If the scanned character is an '(', push it to the stack. 
                else if (c == '(')
                {
                    stack.Push(c);
                }

                // If the scanned character is an ')', pop and output from the stack 
                // until an '(' is encountered. 
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result = result + " " + stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        Console.WriteLine("Invalid Expression"); // invalid expression 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else // an operator is encountered 
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result = result + " " + stack.Pop();
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack 
            while (stack.Count > 0)
            {
                result = result + " " + stack.Pop();
            }
            Console.Write("Postfix Expression::" + result);
            postfix_evaluation(result);
        }
        #endregion
    }
}
