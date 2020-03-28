using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WriteAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllLines("readme.txt", new string[] { "fsdafsa", "fewwerew" });
            Console.WriteLine("写入成功！！");
            Console.ReadKey();
        }
    }
}
