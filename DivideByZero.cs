using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DivideByZero:MyException
    {
        public DivideByZero()
        {
            this.MSG = "MATH ERROR\n";
            Console.WriteLine("\nDIVIDE BY ZERO EXCEPTION OCCURED\nPLEASE ENTER THE VALUE AGAIN\n");
        }
    }
}
