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
            //A manual Process Where a Progammer forcw thw conversion of one type to another using a cast operator.
            /*
            example ; int a = 3;
            float b = a;
            int c = (int)b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hey Hello " + name);
            Console.ReadLine();

        }
    }
}
