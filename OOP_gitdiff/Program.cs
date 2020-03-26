using System;
using System.IO;

namespace OOP_gitdiff
{
    class Program
    {
        public static void Main()
        {
            bool a = FileEquals("..\\..\\file_A.txt", "..\\..\\file_B.txt");

            bool b = FileSize("..\\..\\file_A.txt", "..\\..\\file_B.txt");

            Console.WriteLine("Is the file equal byte by byte?");
            Console.WriteLine(a);
            Console.WriteLine("Is the file equal in length?");
            Console.WriteLine(b);
            Console.ReadLine();
        }

        //checks to see if files are equal byte by byte
        static bool FileEquals(string path1, string path2)
        {
            byte[] file_A = File.ReadAllBytes(@"..\\..\\file_A.txt");
            byte[] file_B = File.ReadAllBytes(@"..\\..\\file_B.txt");
            if (file_A.Length == file_B.Length)
            {
                for (byte i = 0; i < file_A.Length; i++)
                {
                    if (file_A[i] != file_B[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        //checks to see if files are equal in size/length
        static bool FileSize(string filepath_1, string filepath_2)
        {
            bool FileSizeEqual = true;

            //reads file info
            FileInfo fileinfo_A = new FileInfo("..\\..\\file_A.txt");
            FileInfo fileinfo_B = new FileInfo("..\\..\\file_B.txt");

            //compare file sizes (length/lines/characters)
            if (fileinfo_A.Length != fileinfo_B.Length)
            {
                FileSizeEqual = false;
            }
            return FileSizeEqual;
        }
    }
}
