using System;
using System.IO;

namespace ShowFilesDemo
{
    class Program
    {

        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }
        }
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); 
            ShowDirectory(dir);
            Console.ReadKey();
        }
    }

}
