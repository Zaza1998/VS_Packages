using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public void Main(string[] args)
        {
            string standerIdName = "admin", standPassword = "888888";
            Console.WriteLine("请输入用户名");
            string idName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            if (standerIdName != idName)
                Console.WriteLine("该用户名不存在");
            else if (standerIdName == idName && standPassword != passWord)
                Console.WriteLine("密码错误");
            else if(standerIdName == idName && standPassword == passWord)
                Console.WriteLine("登陆成功");
            Console.ReadLine();
        }
    }
}
