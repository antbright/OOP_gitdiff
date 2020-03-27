using System;
using System.IO;

namespace OOP_gitdiff
{
    class Program
    {
        public static void Main()
        {
            bool a = CheckEqual.FileEquals(@"file_A.txt", @"file_B.txt");

            //statement for the file check
            Console.WriteLine("The two files provided are equal.");
            
            //true or false to the statement above
            Console.WriteLine(a);

            //killswitch
            
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
