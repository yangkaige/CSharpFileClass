using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WriteAllBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = Encoding.Default.GetBytes("abcd");
            File.WriteAllBytes("readme.txt", buffer);
            Console.WriteLine("写入成功！！");           
            Console.ReadKey();
        }
    }
}
