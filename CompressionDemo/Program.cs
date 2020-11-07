using System;
using System.IO;
using System.IO.Compression;

namespace CompressionDemo
{
    class Program
    {
        static void CompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = new FileStream(inFilename, FileMode.Open);
            FileStream destFile = new FileStream(outFilename,FileMode.Create);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while(theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            sourceFile.Close();
            compStream.Close();
        }
        static void UncompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = new FileStream(inFilename, FileMode.Open);
            FileStream destFile = new FileStream(outFilename, FileMode.Create);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }
            sourceFile.Close();
            destFile.Close();
        }
        static void Main()
        {
            FileStream fileCreate = new FileStream(@"d:\file.txt", FileMode.Create);
            byte[] inStringFile = {78, 67, 255, 74};
            fileCreate.Write(inStringFile, 0, 4);
            fileCreate.Close();
            CompressFile(@"d:\file.txt", @"d:\file.txt.gz");
            UncompressFile(@"d:\file.txt.gz", @"d:\file2.txt");
        }
    }
}
