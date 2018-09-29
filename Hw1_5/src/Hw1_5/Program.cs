using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw1_5
{
    public class Program
    {
        public void Main(string[] args)
        {
            int Salary = 5000;
            string  Grade;
            Console.WriteLine("请输入李四的评级：");
            Grade = Console.ReadLine();
            switch (Grade )
            {
                case "A":  Salary = Salary + 500;break;
                case "B":  Salary = Salary + 200;break;
                case "C":  break;
                case "D": Salary = Salary - 200; break;
                case "E": Salary = Salary - 500; break;
            }
            Console.WriteLine("李四来年的工资是{0}元", Salary);
            Console.ReadLine();
        }
    }
}
