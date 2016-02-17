using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {            
            DirectoryInfo directory = new DirectoryInfo(@"D:\");
            FileInfo file = new FileInfo(@".\Search Log.txt");
            file.Delete();
            SearchFile(directory);
            Console.WriteLine(new string ('-',80));
            Compress();
            Console.ReadLine();
        }
        static void SearchFile(DirectoryInfo directory)
        {
            try
            {
                FileInfo[] file = directory.GetFiles("*background.png*");
                for (int i = 0; i < file.Length; i++)
                {
                    Console.WriteLine(file[i].FullName);
                    
                    using (FileStream stream = new FileStream(@".\Search Log.txt", FileMode.Append))
                    {
                        byte[] array = File.ReadAllBytes(file[i].FullName);                        
                        stream.Write(array, 0, array.Length);
                    }
                }
            }
            catch 
            {
                return;
            }            
            DirectoryInfo[] dir = directory.GetDirectories();
            for (int i = 0; i < dir.Length; i++)
            {
                SearchFile(dir[i]);
            }
        }
        static void Compress()
        {
            FileStream source = File.OpenRead(@".\Search Log.txt");
            FileStream destination = File.Create(@".\Search Log.zip");            
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);
            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }            
            compressor.Close();
        }
    }
}
