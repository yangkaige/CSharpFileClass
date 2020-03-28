using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileCreate
{
    class Program
    {
        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            FileStream fs = File.Create("readme.txt", 1, FileOptions.Encrypted);
            byte[] buffer = Encoding.Default.GetBytes("fsdafds工工工");
            fs.Write(buffer, 0, buffer.Length);
            Console.WriteLine("创建成功！！");
            Console.ReadKey();
        }
    }
}
