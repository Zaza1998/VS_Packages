using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum;
            Console.WriteLine("请输入一个数");
            inputNum = int.Parse(Console.ReadLine());
            for (int i = 0; inputNum >= 0; inputNum--, i++)
            {
                Console.WriteLine(" {0} + {1} = {2} ", i, inputNum, i + inputNum);
            }
            Console.ReadLine();

        }
    }
}
