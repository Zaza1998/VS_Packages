using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw1_2
{
    public class Program
    {
        public void Main(string[] args)
        {
            int eggNum, badEggNum;
            Console.WriteLine("请输入买入鸡蛋个数：");
            eggNum = int.Parse(Console.ReadLine());
            Random ran = new Random();

            badEggNum = ran.Next (0, eggNum);
            if (badEggNum < 5) Console.WriteLine("请留下来吃掉");
            else Console.WriteLine("请拿去退货");
            Console.ReadLine();

        }
    }
}
