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
        static void Main(string[] args) {
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

            //1.

            //string hello = "Hello world this is grahit";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.ReadLine();

            //2.

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name} You will get {candies} candies Enjoy!!!");
            //Console.ReadLine();

            //3.

            //string hello = "Hello World";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello[2]);
            //Console.WriteLine(hello[3]);
            //Console.WriteLine(hello[4]);
            //Console.WriteLine(hello[5]);
            //Console.WriteLine(hello[6]);
            //Console.WriteLine(hello[7]);
            //Console.WriteLine(hello[8]);
            //Console.WriteLine(hello[9]);
            //Console.WriteLine(hello[10]);
            //Console.ReadLine();

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

            //4.

            //string hello = "Hello World This is Grahit";

            //Console.WriteLine(hello.IndexOf("Hello"));
            //Console.WriteLine(hello.IndexOf("World"));
            //Console.WriteLine(hello.IndexOf("This"));
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.IndexOf("Grahit"));
            //Console.ReadLine();

            //Output
            //0
            //6
            //12
            //14
            //20

            //5.

            //string hello = "Hello World This is Grahit";
            //Console.WriteLine(hello.Substring(12));
            //Console.ReadLine();

            //Output
            //This is Grahit

            //Note :- There are more string method to explore and these string method are just for understanding how we can use string methods.


            //Escape sequence characters


            /*
                 Characters |     Meaning     |      Examples      |      Output
                            |                 |                    |
                     \n     |    New line     |  "Hello\nWorld"    |      Hello
                            |                 |                    |      World
                            |                 |                    |
                     \t     |  Horizontal tab |  "Name:\tAlex"     |     Name: Alex
                            |                 |                    |
                     \"	    |   Double quote  |  "He said \"Hi\""  |  He said "Hi"

            */

            //Console.WriteLine("Raman said \"hi\"");
            //Console.ReadLine();



            //Console.WriteLine("Enter your Age");
            //string Age = Console.ReadLine();
            //int age = Convert.ToInt32(Age);

            //if (age == 18)
            //{
            //    Console.WriteLine("You can Drive a car");
            //    Console.ReadLine();
            //}

            //else if (age < 2)
            //{
            //    Console.WriteLine("You are just born");
            //    Console.ReadLine();
            //}

            //else if (age < 10)
            //{
            //    Console.WriteLine("Finish your high school");
            //    Console.ReadLine();
            //}

            //else if (age < 22)
            //{
            //    Console.WriteLine("College age");
            //    Console.ReadLine();
            //}

            //else
            //{
            //    Console.WriteLine("You cannot Drive the car");
            //    Console.ReadLine();

            //Console.WriteLine("Finding memes of year _");
            //string Year = Console.ReadLine();
            //int year = Convert.ToInt32(Year);

            //switch (year)
            //{
            //    case 2020:
            //        Console.WriteLine("Binod");
            //        Console.ReadLine();
            //        break;

            //    case 2021:
            //        Console.WriteLine("Gajab Bezzati Ha");
            //        Console.ReadLine();
            //        break;

            //    case 2022:
            //        Console.WriteLine("Pawri hori hai");
            //        Console.ReadLine();
            //        break;

            //    case 2023:
            //        Console.WriteLine("Bhupendra Jogi");
            //        Console.ReadLine();
            //        break;

            //    case 2024:
            //        Console.WriteLine("Elvish Bhai ke aage koi bol sakta hai kya");
            //        Console.ReadLine();
            //        break;

            //    case 2025:
            //        Console.WriteLine("Chin Tapak Dam Dam");
            //        Console.ReadLine();
            //        break;

            //    case 2026:
            //        Console.WriteLine("Money follows my brother");
            //        Console.ReadLine();
            //        break;

            //    default:
            //        Console.WriteLine("Insert only year from 2020 to 2026");
            //        Console.ReadLine();
            //        break;

            //Loops

            //1.While loop

            //int i = 0;
            //while (i < 10000)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //2.Do while loop
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i > 5);
            
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+ 1);
            //    Console.ReadLine();
            //}
        }
    }
}
