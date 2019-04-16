using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace practical_5
{
    class listdir
    {
        static void Main()
        {
            string[] Directories = Directory.GetDirectories(@"D:\study");
            Console.WriteLine("All the Directories are:");
            foreach (string dir in Directories)
            {
                //Console.WriteLine("All the Directories are:");
                Console.WriteLine(dir);
            }
            string[] files = Directory.GetFiles(@"D:\study");
            Console.WriteLine("All the Files are:");
            foreach (string file in files)
            {
                // Console.WriteLine("All the Files are:");
                Console.WriteLine(file);
            }
            Console.ReadLine();
        }
    }
}
