
using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main()
        {
            StreamWriter writer = File.CreateText(@"d:\newfile.txt");
            writer.WriteLine("First string");
            writer.WriteLine("Second string");
            writer.Close();
            StreamReader reader = File.OpenText(@"d:\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
            Console.ReadKey();
        }
    }
}