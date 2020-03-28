using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = File.ReadAllLines("readme.txt", Encoding.UTF8);
            int index = 0;
            while (index < strs.Length)
            {
                Console.WriteLine(strs[index]);
                index++;
            }
            Console.ReadKey();
        }
    }
}
