using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLamdaApp
{
    internal class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach(string s in arr)
                    result += s;
                
                return result;
            };

            Console.WriteLine(concat(args));
        }
    }
}
