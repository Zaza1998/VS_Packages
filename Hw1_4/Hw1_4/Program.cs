using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string standIdname = "admin";
            string standPassword = "888888";
            Console.WriteLine("请输入你的用户名");
            string Idname = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string Password = Console.ReadLine();
            if (standIdname != Idname) Console.WriteLine("用户名不存在");
            else if (standPassword != Password) Console.WriteLine("密码错误");
            else Console.WriteLine("输入正确");
            Console.ReadLine();

        }
    }
}
