using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopyApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "C:\\Temp\\A.txt";
            string path2 = "C:\\Temp\\C.txt";

            using (FileStream fs = new FileStream(path1, FileMode.Open))
            {
                File.Copy(path1, path2);
            }
        }
    }
}
