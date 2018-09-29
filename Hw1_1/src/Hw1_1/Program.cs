using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw1_1
{
    public class Program
    {
        public void Main(string[] args)
        {
            string  grade;
            Console.WriteLine("请输入你的成绩：");
            grade =Console.ReadLine();
            int gradenum = int.Parse(grade);
            if (gradenum >= 90) Console.WriteLine("Your grades are A");
            else if (gradenum >= 80 && gradenum < 90) Console.WriteLine("Your grades are B");
            else if (gradenum >= 70 && gradenum < 80) Console.WriteLine("Your grades are C");
            else if (gradenum >= 60 && gradenum < 70) Console.WriteLine("Your grades are D");
            else Console.WriteLine("Your grades are E");
            Console.ReadLine();

        }
    }
}
