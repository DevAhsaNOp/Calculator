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

        public void root_of_power(double n, int pow)
        {
            double result = Math.Pow(n, (double)1 / pow);
            Console.Write("Root OF POWER {0} IS:{1}", pow, result);
        }
        long Bin_to_Dec(long bin)
        {
            long rem, sum = 0, i = 0;
            while (bin != 0)
            {
                rem = bin % 10;
                bin = bin / 10;
                sum = sum + rem * (int)Math.Pow(2, i);
                i++;
            }
            return sum;
        }
        void Bin_to_Oct(long bin)
        {
            int i = 0, len = 0;
            int rem, sum = 0;
            int[] remain = new int[100];
            while (bin != 0)
            {
                rem = (int)bin % 10;
                bin = bin / 10;
                sum = sum + rem * (int)Math.Pow(2, i);
                i++;
            }
            i = 0;
            while (sum != 0)
            {
                remain[i] = sum % 8;
                sum = sum / 8;
                i++;
                len++;
            }
            Console.WriteLine("\nEquivalent Octal Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                Console.Write(remain[i]);
            }
        }
        void Bin_to_Hex(long bin)
        {
            int rem, i = 0, sum = 0, len = 0;
            int[] remain = new int[100];

            while (bin != 0)
            {
                rem = (int)bin % 10;
                bin = bin / 10;
                sum = sum + rem * (int)Math.Pow(2, i);
                i++;
            }
            i = 0;
            while (sum != 0)
            {
                remain[i] = sum % 16;
                sum = sum / 16;
                i++;
                len++;
            }
            Console.WriteLine("\nEquivalent Hexa-decimal1 Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                switch (remain[i])
                {
                    case 10:
                        Console.Write("A"); break;

                    case 11:
                        Console.Write("B"); break;

                    case 12:
                        Console.Write("C"); break;

                    case 13:
                        Console.Write("D"); break;

                    case 14:
                        Console.Write("E"); break;

                    case 15:
                        Console.Write("F"); break;

                    default:
                        Console.Write(remain[i]);
                        break;
                }

            }
        }
        void Dec_to_Bin(long dec)
        {
            int[] rem = new int[50];
            int i=0, len = 0;
            do
            {
                rem[i] = (int)dec % 2;
                dec = dec / 2;
                i++;
                len++;
            }
            while (dec != 0);

            Console.WriteLine("\nEquivalent Binary Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                Console.Write(rem[i]);
            }
        }

        void Dec_to_Oct(long dec)
        {
            int[] rem = new int[50];
            int i=0, len = 0;
            do
            {
                rem[i] = (int)dec % 8;
                dec = dec / 8;
                i++;
                len++;
            }
            while (dec != 0);

            Console.WriteLine("\nEquivalent Octal Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                Console.Write(rem[i]);
            }
        }
        void Dec_to_Hex(long  dec)
        {
            int[] rem = new int[50];
            int i=0, len = 0;
            do
            {
                rem[i] = (int)dec % 16;
                dec = dec / 16;
                i++;
                len++;
            }
            while (dec != 0);

            Console.WriteLine("\nEquivalent Hexa-decimal1 Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                switch (rem[i])
                {
                    case 10:
                        Console.Write("A"); break;

                    case 11:
                        Console.Write("B"); break;

                    case 12:
                        Console.Write("C"); break;

                    case 13:
                        Console.Write("D"); break;

                    case 14:
                        Console.Write("E"); break;

                    case 15:
                        Console.Write("F"); break;

                    default:
                        Console.Write(rem[i]);
                        break;
                }

            }
        }
        void Oct_to_Bin(long  oct)
        {
            int[] rem = new int[50];
            int len = 0,decimal1= 0, i = 0, num, ans;

            while (oct != 0)
            {
                ans = (int)oct % 10;
                decimal1 = decimal1 + ans * (int)Math.Pow(8, i);
                i++;
                oct = oct / 10;
            }

            i = 0;
            do
            {
                rem[i] = decimal1 % 2;
                decimal1= decimal1 / 2;
                i++;
                len++;
            }
            while (decimal1 != 0);

            Console.WriteLine("\nEquivalent Binary Number : ");
            for (i = len - 1; i >= 0; i--)
            {
                Console.WriteLine(rem[i]);
            }
        }

        void Oct_to_Dec(long  oct)
        {
            int decimal11= 0, i = 0, num, ans;

            while (oct != 0)
            {
                ans = (int)oct % 10;
                decimal11 = decimal11 + ans * (int)Math.Pow(8, i);
                i++;
                oct = oct / 10;
            }
            Console.WriteLine("\nEquivalent decimal1 Number :"+decimal11);
        }


        public void CONVERTER()
        {
            int n;
            Console.WriteLine("ENTER\n1. BIN TO DEC\n2. BIN TO OCT\n3. BIN TO HEX\n4. DEC TO BIN\n5. DEC TO OCT\n6. OCT TO BIN\n7. OCT TO DEC\n");
            int I = int.Parse(Console.ReadLine());
            switch (I)
            {
                case 1:
                    Console.WriteLine("ENTER BINARY NUMBER");
                    n = int.Parse(Console.ReadLine());
                    long x = Bin_to_Dec(n);
                    Console.WriteLine("AMSWER IS: "+x);
                    break;
                case 2:
                    Console.WriteLine("ENTER BINARY NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Bin_to_Oct(n);
                    break;
                case 3:
                    Console.WriteLine("ENTER BINARY NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Bin_to_Hex(n);
                    break;
                case 4:
                    Console.WriteLine("ENTER DECIMAL NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Dec_to_Bin(n);
                    break;
                case 5:
                    Console.WriteLine("ENTER DECIMAL NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Dec_to_Oct(n);
                    break;
                case 6:
                    Console.WriteLine("ENTER OCTAL NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Oct_to_Bin(n);
                    break;
                case 7:
                    Console.WriteLine("ENTER OCTAL NUMBER");
                    n = int.Parse(Console.ReadLine());
                    Oct_to_Dec(n);
                    break;

                default:
                    break;
            }
        }
        public void EQUATION()
        {
            double a, b, c, real, determinant, root1, root2, imaginaryPart;
            Console.WriteLine("Enter values of a, b and c: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            while (a == 0 || c == 0 || b == 0)
            {
                Console.WriteLine("error \n");
                
                Console.WriteLine("Enter values of a, b and c: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

            }
            if (a != 0 || b != 0 || c != 0)
            {
                determinant = b * b - 4 * a * c;
                real = -b / (2 * a);
                //real and different roots
                if (determinant > 0)
                {
                    root1 = real + Math.Sqrt(determinant) / (2 * a);
                    root2 = real - Math.Sqrt(determinant) / (2 * a);
                    Console.WriteLine("\nroot1 = {0} \nroot2 = {1}", root1, root2);
                }
                //real and equal roots
                else if (determinant == 0)
                {
                    root1 = root2 = real;
                    Console.WriteLine("\nroot1 = root2 = {0};", root1);
                }
                //not real
                else if (determinant < 0)
                {
                    imaginaryPart = Math.Sqrt(-determinant) / (2 * a);
                    Console.WriteLine("\nroot1 = {0}+{1}i \nroot2 = {2}-{3}i", real, imaginaryPart, real, imaginaryPart);
                }
            }
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
                    if (n <= 0)
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
                    if (n <= 0)
                    {
#pragma warning disable CS0162 // Unreachable code detected
                        Console.WriteLine("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0\n");
#pragma warning restore CS0162 // Unreachable code detected
                        throw new MathError();
                    }
                    else
                    {
                        Console.WriteLine("LOG10 OF {0} IS: {1}", n, 1 / (n));
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
                    if (pow == 0)
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
