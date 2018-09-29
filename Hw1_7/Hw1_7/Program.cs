using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1,Max = 0,temp;
            string stopEvent = "end",inputStr;

            while (flag==1)
            {
                Console.WriteLine("请输入一个数（如果想停止输入，请输入end）");
                inputStr = Console.ReadLine();
                if (inputStr == stopEvent) break;
                if (int.Parse(inputStr) > Max)
                    Max = int.Parse(inputStr);                
            }
            Console.WriteLine("输入的最大数是：" + Max);
            Console.ReadLine();
        }
    }
}
