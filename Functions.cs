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
        public double nPr(double n, double r)
        {
                return fact(n) / fact(n - r);  
        }
        public double nCr(double n, double r)
        {
            return fact(n) / (fact(r) * fact(n - r));
        }
        public int GCD(int a, int b)
        {
            if (a == 0)
                return 0;
            return GCD(b % a, a);
        }
        public int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public void root_of_power(double n,int pow)
        {
            double result = Math.Pow(n, (double)1 / pow);
            Console.Write("Root OF POWER {0} IS:{1}",pow,result);
        }
        public void Logarthimic_Function()
        {
            char ch;
            double n;
            Console.WriteLine("SELECT THE FOLLOWING OPTIONS");
            Console.WriteLine("1. LOG\n2. LOG10\n3. SQUARE ROOT\n4. CUBEROOT\n5. FACTORIAL\n6. Ln\n7. nPr\n8. nCr\n9. ROOT OF ANY POWER");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '1':
                    Console.Write("Enter the Number : ");
                    n = double.Parse(Console.ReadLine());
                    if (n<=0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("LOG OF {0} IS: {1}", n, Math.Log(n));
                    }
                    break;
                case '2':
                    Console.Write("Enter the Number : ");
                    n = double.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("LOG10 OF {0} IS: {1}", n, Math.Log10(n));
                    }
                    break;
                case '3':
                    Console.Write("Enter the Number : ");
                    n = double.Parse(Console.ReadLine());
                    if (n < 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("SQUARE ROOT OF {0} IS: {1}", n, Math.Sqrt(n));
                    }
                    break;
                case '4':
                    double number, result;
                    Console.Write("Enter the Number : ");
                    number = Convert.ToDouble(Console.ReadLine());
                    result = Math.Ceiling(Math.Pow(number, (double)1 / 3));
                    Console.Write("Cube Root : " + result);
                    break;
                case '5':
                    Console.WriteLine("ENTER THE NUMBER:");
                    int x = int.Parse(Console.ReadLine());
                    if (x < 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("\nSYNTAX ERROR\nFACTORIAL OF LESS THAN 0 IS NOT POSSIBLE\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("ANSWER IS:" + fact(x));
                    }
                    break;
                case '6':
                    Console.WriteLine("ENTER THE NUMBER");
                    n = double.Parse(Console.ReadLine());
                    if (n<=0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("LOG10 OF {0} IS: {1}", n,1/(n));
                    }
                    break;
                case '7':
                    Console.WriteLine("ENTER VALUE OF N");
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER THE VALUE OF R");
                    double r = double.Parse(Console.ReadLine());
                    if (n < 0 || r < 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD BE GREATER THAN 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        double asn = nPr(n, r);
                        Console.WriteLine("ANSWER IS:" + asn);
                    }
                    break;
                case '8':
                    Console.WriteLine("ENTER VALUE OF N");
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER THE VALUE OF R");
                    r = double.Parse(Console.ReadLine());
                    if (n < 0 || r < 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD BE GREATER THAN 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        double asn = nCr(n, r);
                        Console.WriteLine("ANSWER IS:" + asn);
                    }
                    break;
                case '9':
                    Console.Write("Enter the Number : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("ENTER POWER OF ROOT: ");
                    int pow = int.Parse(Console.ReadLine());
                    if(pow==0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE ROOT OF POWER 0 IS INDERTMINATE\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();

                    }
                    else
                    {
                        root_of_power(n, pow);
                    }
                    break;
            }
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
                    if (n<-1||n>1)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN -1 OR  GREATER THAN 1\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                        Console.WriteLine("ANSWER IN DEEGREE IS:" + 1 / Math.Sin(n));
                    }
                    break;
                case '5':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    if (n < -1 || n > 1)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN -1 OR  GREATER THAN 1\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                        Console.WriteLine("ANSWER IN DEEGREE IS:" + 1 / Math.Cos(n));
                    }
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
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Cosh(n));
                    break;
                case '9':
                    Console.WriteLine("ENTER THE VALUE IN RADIAN");
                    n = double.Parse(Console.ReadLine());
                    n = (n * 3.14) / 180; //RADIAN TOD DEGREE//
                    Console.WriteLine("ANSWER IN DEEGREE IS:" + Math.Tanh(n));
                    break;

                default:
                    Console.WriteLine("ENTER VALID CHOICE");
                    n = double.Parse(Console.ReadLine());
                    break;
            }
        }
        
    }
    
}
