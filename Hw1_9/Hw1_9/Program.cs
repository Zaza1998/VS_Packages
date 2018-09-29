using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_9
{
    class Program
    {
        static void assignment(string[] arr1, string[] arr2,int i)
        {
            
                Console.WriteLine("请输入你新建的的用户名");
                arr1[i] = Console.ReadLine();
                Console.WriteLine("请输入你新建的密码");
                arr2[i] = Console.ReadLine();
                Console.WriteLine("新建成功，用户名：" + arr1[i] + "密码：" + arr2[i]+ "请记住您的序号为" + i);
            
        }

        static void ChangePassword(string[] arr1, string[] arr2)
        {
            int j;
            String Idname;
            Console.WriteLine("下面进入身份核验！");
            Console.WriteLine("请输入你的序号：");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的用户名");
            Idname = Console.ReadLine();
            if( arr1[j] == Idname)
            {
                Console.WriteLine("身份核验成功");
                Console.WriteLine("请输入新的密码：");
                arr2[j] = Console.ReadLine();
                Console.WriteLine("密码重置成功，用户名：" + arr1[j] + "密码：" + arr2[j] + "请记住您的序号为" + j);
            }


        }

        static void Main(string[] args)
        {
            string[] standIdname = new string[1000];
            string[] standPassword = new string[1000];
            //string[] standIdname = { "new", "new", "new" };
            //string[] standPassword = { "new", "000000", "000000" };
            int flag = 1, k;
            int i = 0;
            while (flag == 1)
            {
                Console.WriteLine("请输入你的序号：");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的用户名");
                string Idname = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string Password = Console.ReadLine();

                if (standIdname[k] != Idname)
                {
                    Console.WriteLine("用户名不存在");
                    Console.WriteLine("是否需要注册，如果是请输入‘yes’");
                    if (Console.ReadLine() == "yes") {
                        assignment(standIdname, standPassword,i++);

                    }
                }

                else if (standPassword [k]!= Password)
                {
                    Console.WriteLine("密码错误");
                    Console.WriteLine("是否需要重置密码，如果是请输入‘yes’");
                    if (Console.ReadLine() == "yes")
                    {
                        ChangePassword(standIdname, standPassword);

                    }
                }
                else
                {
                    Console.WriteLine("输入正确，登陆成功");
                    flag = 0;
                }
            }
            Console.ReadLine();
        }
    }
}

