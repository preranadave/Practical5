using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace practical_5
{
    class copyfile
    {
        static void Main(string[] args)
        {
            CopyFile cp = new CopyFile();
            String file1 = @"D:\study\file1.txt";
            String file2 = @"D:\study\file2.txt";
            cp.copyFile(file1, file2);
            Console.ReadKey();
        }
    }
    public class CopyFile
    {
        public void copyFile(String file1, String file2)
        {
            using (StreamReader reader = new StreamReader(file1))
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    String line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
