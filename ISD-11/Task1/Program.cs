using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"."); 
            string s = "Folder_";
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory(s + i);
            }            
            DirectoryInfo[] dirCreate = directory.GetDirectories(".");
            foreach (DirectoryInfo d in dirCreate)
            {
                Console.WriteLine(d.Name);
            }
            Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
               Directory.Delete(s+i);                
            }
            DirectoryInfo[] dirDelete = directory.GetDirectories(".");
            foreach (DirectoryInfo d in dirDelete)
            {
                Console.WriteLine(d.Name);
            }
            Console.ReadLine();
        }
    }
}
