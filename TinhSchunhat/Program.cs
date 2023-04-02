using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhSchunhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float dai, rong, s;
            Console.Write("Nhập chiều dài hình chữ nhật:");
            dai= float.Parse(Console.ReadLine());
            Console.Write("Mời nhập chiều rộng hình chữ nhật:");
            rong= float.Parse(Console.ReadLine());
            s = dai * rong;
            Console.WriteLine("Diện tích hình chữ nhật là: " +s);
            Console.ReadLine();
        }
    }
}
