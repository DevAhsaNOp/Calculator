using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string postfix;
            //InfixtoPostfix infixtoPostfix = new InfixtoPostfix();
            //Console.WriteLine("\t\t\t\t\tPlease Give Spaces In Writing Expression Like This\n :: (22+3-(1/2))\n");
            //Console.WriteLine("\t\t\t\t\tIf Your Input Digit Contains - means it's a Negative Value replace - with  ! and Input Like this !22.1/3");
            //Console.WriteLine("\n\nEnter the Infix Expression:: ");
            //postfix = Console.ReadLine();
            //if (CheckValid(postfix))
            //{
            //    infixtoPostfix.infixToPostfix(postfix);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input Please Give The Input in Correct Form");
            //}
            //Console.ReadLine();
            Functions Function = new Functions();
            //Function.TRIGNOMETRY();
            ////Console.ReadLine();
            //Console.WriteLine("ENTER THE VALUE OF A AND B");
            //int a = int.Parse(Console.ReadLine());
            //int b= int.Parse(Console.ReadLine());
            //int c=Function.GCD(a, b);
            //Console.WriteLine(c);
            //int C = Function.LCM(a, b);
            //Console.WriteLine(C);
            int i = 0;
            while (i==0)
            {
                Function.CONVERTER();
                Console.WriteLine("\nCONTINUE 0 OR EXIT 1");
                i = int.Parse(Console.ReadLine());
            }
            
        }

        public static bool CheckValid(string my_string)
        {
            string array = "0123456789+-*/^().! ";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
