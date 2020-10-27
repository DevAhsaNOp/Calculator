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
            infixtoPostfix.infixToPostfix(postfix);
            Console.ReadLine();
        }
    }
}
