using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadAllBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = File.ReadAllBytes("readme.txt");            
            Console.WriteLine(Encoding.GetEncoding("UTF-8").GetString(buffer,0,buffer.Length));
            Console.ReadKey();
        }
    }
}
