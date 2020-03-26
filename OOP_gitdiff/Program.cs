using System;
using System.IO;

namespace OOP_gitdiff
{
    class Program
    {
        public static void Main()
        {
            bool a = CheckEqual.FileEquals("..\\..\\file_A.txt", "..\\..\\file_B.txt");

            Console.WriteLine("The two files provided are equal.");
            Console.WriteLine(a);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
