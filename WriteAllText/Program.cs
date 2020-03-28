using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WriteAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("readme.bin","fewfw在有ef");
            Console.WriteLine("写入成功！！");
            Console.ReadKey();
        }
    }
}
