using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw1_6
{
    public class Program
    {
        public void Main(string[] args)
        {
            double Population = 80000;
            int year=2006;
            while(Population < 200000)
            {
                Population = 1.25 * Population;
                year++;
                Console.WriteLine("第{0}年的人数为:{1}",year  , Population );
            }
            Console.WriteLine("-------------------分割线--------------------");
            Console.WriteLine("由上面计算可得在第{0}年培训人数达到20万人",year);
            Console.ReadLine();
        }
    }
}
