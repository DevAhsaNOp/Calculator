using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Functions
    {
        public double fact(double n)
        {
            if (n <= 1)
                return 1;
            return n * fact(n - 1);
        }
        public double nPr(double n,double r)
        {
            return fact(n) / fact(n - r);
        }
        public double nCr9(double n,double r)
        {
            return fact(n) / (fact(r) * fact(n - r));
        } 
        public int GCD (int a,int b)
        {
            if (a == 0)
                return 0;
            return GCD(b % a, a);
        }
        public int LCM (int a ,int b)
        {
            return (a * b) / GCD(a,b);
        }
        public void TRIGNOMETRY()
        {
            char ch;
            double n;
            Console.WriteLine("SELECT THE FOLLOWING OPTIONS");
            Console.WriteLine("1. Sin\n2. Cosine\n3. Tangent\n4. Cosec\n5. Sec\n6. Cot\n7. Sinh\n8. Cosh\n9. Tanh");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '1':
                        
                        Console.WriteLine("ENTER THE VALUE IN RADIAN");
                        n = double.Parse(Console.ReadLine());
                        n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                        Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Sin(n));
                        break;
                    
                case '2':

                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Cos(n));
                    break;
                case '3':
                    
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Tan(n));
                    break;

                case '4':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + 1/Math.Sin(n));
                    break;
                case '5':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + 1 / Math.Cos(n));
                    break;
                case '6':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + 1 / Math.Tan(n));
                    break;
                case '7':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Sinh(n));
                    break;
                case '8':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" +Math.Cosh(n));
                    break;
                case '9':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" +Math.Tanh(n));
                    break;

                default:
                    Console.WriteLine("ENTER VALID CHOICE");
                    n = double.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
