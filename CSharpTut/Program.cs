using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        /// <summary>
        /// `static` because you don't need to make a new object to call Main.
        /// `void` means it returns nothing.
        /// </summary>
        /// <param name="args">
        /// The first element is the path of the executable.
        /// Subsequent elements are the passed values.
        /// </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 0; i < args.Length; i++)
            {
                /// The braces contain numbers, which are the indices for the remaining arguents to Console.WriteLine
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            /// Environment.GetCommandLineArgs returns a list of strings.
            /// The first string is the path to the executable.
            /// The remaining strings are the passed arguments.
            string[] myArgs = Environment.GetCommandLineArgs();

            /// string.Join takes a separator and a list of strings to concatenate.
            Console.WriteLine(string.Join(", ", myArgs));

            SayHello();

            Console.ReadLine();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
