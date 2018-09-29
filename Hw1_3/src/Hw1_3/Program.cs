using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw1_3
{
    public class Program
    {
        public void Main(string[] args)
        {
            int flag =1 ,count = 1;
            Random ran = new Random();
            while (flag ==1){
                Console.WriteLine("这是小兰的第{0}次练习",count);
                Console.WriteLine("老师:不满意，请继续训练");
                flag = ran.Next(0, 1);
                count++;
            }
            Console.WriteLine("这是小兰的第{0}次练习", count);
            Console.WriteLine ("满意，可以回家啦！小兰总共练习了{0}次",count);
            Console.ReadLine();
        }
    }
}
