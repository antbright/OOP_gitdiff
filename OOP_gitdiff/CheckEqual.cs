using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_gitdiff
{
    class CheckEqual
    {
        public static bool FileEquals(string path1, string path2)
        {
            //reading both files byte by byte
            byte[] file_A = File.ReadAllBytes(@"..\\..\\file_A.txt");
            byte[] file_B = File.ReadAllBytes(@"..\\..\\file_B.txt");
            
            //checking if files are equal
            if (file_A.Length == file_B.Length)
            {
                for (byte i = 0; i < file_A.Length; i++)
                {
                    if (file_A[i] != file_B[i])
                    {
                        //return false if not the same
                        return false;
                    }
                }
                //otherwise return true
                return true;
            }
            //return false if file length aren't the same
            return false;
        }
    }
}
