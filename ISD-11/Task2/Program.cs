using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (StreamWriter write = new StreamWriter(File.Open(@".\My File.txt", FileMode.OpenOrCreate)))
            {
                write.WriteLine("1 line");
                write.WriteLine("2 line");
                write.WriteLine("3 line");
                write.WriteLine("4 line"); 
                write.WriteLine("5 line"); 
            }
            using (StreamReader reader = new StreamReader(File.Open(@".\My File.txt",FileMode.Open)))
            {
                while (reader.Peek() != -1)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
