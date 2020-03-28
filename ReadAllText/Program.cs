using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("readme.bin");
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
