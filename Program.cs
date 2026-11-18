using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Helllo
{
   class Program
    {
        static void Main(string[] args)
        {
            //int a = 3;
            //float b = a;
            //int c = (int)b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Typecasting is process in which we can convert variables or values into another Data Types.
            //there are two types of typecasting
            //1.Implicit type casting.
            //char to int to long to float to double.

            //2.Explicit type casting.
            //A manual Process Where a Progammer force the conversion of one type to another using a cast operator.
            /*
            example ; int a = 3;
            float b = a;
            int c = (int)b;            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */


            //double DoubleV = 12.75;
            //int intV = Convert.ToInt32(DoubleV)

            //int x = (int)3.4;
            //char y = (char)65;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadLine();

            //Function - x

            //Console.WriteLine("What is your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi " + name);

            //Console.WriteLine("How many candies do you want");
            //string can = Console.ReadLine();
            //Console.WriteLine("Fantastic you will get 4 more candies " + can + 4);
            //Console.ReadLine();

            //Instead of getting 9 we get 54, to fix function - x , we need to use Typecasting using methods to convert string 'can' to int and also we have to use parameteres to prioritize.

            //Console.WriteLine("What is your name");
            //string name = Console.ReadLine(); 
            //Console.WriteLine("Hi " + name);

            //Console.WriteLine("How many candies do you want");
            //string can = Console.ReadLine();
            //Console.WriteLine("Fantastic you will get 4 more candies " + (Convert.ToInt32(can) + 4));
            //Console.ReadLine();
            //Now the Output 10 after giving 6 input.

            //Operators

            //1.Arithmetic operator.

            // int b = 2;
            // int a = 4;
            // Console.WriteLine("the value of a+b is : " + (a + b));
            // Console.WriteLine("the value of a-b is : " + (a - b));
            // Console.WriteLine("the value of a*b is : " + (a * b));
            // Console.WriteLine("the value of a/b is : " + (a / b));
            // Console.ReadLine();

            //2.Assignment operator.

            //int a = 4;
            //int b = a;

            //b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;

            //Console.WriteLine(b);
            //Console.ReadLine();

            // 3. Logical operator

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //Console.WriteLine(!true);
            //Console.WriteLine(!false);
            //Console.ReadLine();

            //4.Comparison Operator

            //Console.WriteLine(32 > 42);
            //Console.WriteLine(32 < 42);
            //Console.WriteLine(32 >= 42);
            //Console.WriteLine(32 <= 42);
            //Console.WriteLine(32 != 42);
            //Console.WriteLine(32 == 42);
            //Console.WriteLine(32 == 32);
            //Console.ReadLine();



            //Math classes in c#.

            //1.
            //int a = Math.Max(31 ,32);
            //Console.WriteLine(a);

            //2.
            //int b = Math.Min(31, 32);
            //Console.WriteLine(b);

            //3.
            //double c = Math.Sqrt(39);
            //Console.WriteLine(c);
            //Console.ReadLine();

            //4.
            //double d = Math.Abs(-39);
            //Console.WriteLine(d);
            //Console.ReadLine();

            //Introduction to Strings.

            //string hello = "Hello world this is grahit";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.ReadLine();

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name} You will get {candies} candies Enjoy!!!");
            //Console.ReadLine();

            string hello = "Hello World";
            Console.WriteLine(hello[0]);
            Console.WriteLine(hello[1]);
            Console.WriteLine(hello[2]);
            Console.WriteLine(hello[3]);
            Console.WriteLine(hello[4]);
            Console.WriteLine(hello[5]);
            Console.WriteLine(hello[6]);
            Console.WriteLine(hello[7]);
            Console.WriteLine(hello[8]);
            Console.WriteLine(hello[9]);
            Console.WriteLine(hello[10]);
            Console.ReadLine();

            //OutPut
            //H
            //e
            //l
            //l
            //o

            //W
            //o
            //r
            //l
            //d
        }
    }
}
