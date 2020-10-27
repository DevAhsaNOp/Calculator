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
                string x = ""; float read_x = 0; char c = ' ';
                if (postfix[i] == ' ')
                    continue;
                #region multidigit_check
                //else if (char.IsDigit(postfix[i]))
                //{
                //int num = 0;

                //while (char.IsDigit(postfix[i]))
                //{
                //    num = num * 10 + (postfix[i] - '0');
                //    i++;
                //}
                //i--;
                //stack.Push(num);
                //}
                #endregion
                //If c is a number or decimal point
                else if (CharUtil.IsDigit(c = postfix[i]))
                    {                        x += c;
                        //The cycle reading includes a decimal point (for example, 8.88+7.777, here will be read in three times, the first cycle reads 8.88, the second time reads +, the third cycle reads 7.77)
                        while (i < len - 1 && CharUtil.IsDigit(c = postfix[++i]))                            x += c;                        read_x = float.Parse(x);
                        //Read the data into the data stack
                        stack.Push(read_x);
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
                    result = result + operand.ToString() + " ";

                }
                else if (exp[i]=='.')
                {
                    result = result.Trim() + exp[i];
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
  class CharUtil
        {
            public static bool IsDigit(char c)
            {
                return (c >= 48 && c <= 57 || c == '.') ? true : false;
            }
        }


    }
}
