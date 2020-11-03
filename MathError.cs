using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MathError:MyException
    {
        public MathError()
        {
            this.MSG = "MATH ERROR";
            Console.WriteLine("MATH ERROR OCCURED\n");
        }
        
    }
}
