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
            string postfix;
            InfixtoPostfix infixtoPostfix = new InfixtoPostfix();
            Console.WriteLine("\t\t\t\t\tPlease Give Spaces In Writing Expression Like This :: ( 22 + 3 - (1 / 2))\n");
            Console.WriteLine("\n\nEnter the Infix Expression:: ");
            postfix = Console.ReadLine();
            if (CheckValid(postfix))
            {
                infixtoPostfix.postfix_evaluation(postfix);
            }
            else
            {
                Console.WriteLine("Invalid Input Please Give The Input in Correct Form");
            }
            Console.ReadLine();
        }

        public static bool CheckValid(string my_string)
        {
            string array = "0123456789+-*/^(). ";

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
