using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using namespace by yourself
//这是单行注释
/*
 这是一个多行注释;
     */
/// <summary>
/// 对文件的说明
/// </summary>
namespace ConsoleApplication1 //逻辑空间，把类分装在不同的逻辑类型里面，同时在同一个名称空间里面可以做类和类的联系处理。
{
    class Program //class 前可以加public、private、protected来进行封装。
    {
        static void Main(string[] args)//具体创建的方法
        {
            //常量的定义,常量是不能够被再次赋值的
            const double PI = 3.14;
        //扩缩功能展示
        #region
        Console.WriteLine("Hello world!");
            String abc = System.Console.ReadLine();
        #endregion
        Console.WriteLine("print readline:" + abc);
            int c = add(3, 5);
        Console.WriteLine("值是：" + c);
            Console.ReadLine();
            //随机数方法,x获得1-6中的随机整数
            Random ran = new Random();
        int x;
        x = ran.Next(1, 6);
            int[] myarray1;

        myarray1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] myarray2 = { };
        int[] myarray3 = { 1, 2, 3 };//初始赋值
        int[] myarray4 = new int[5];//初始值都将被赋成0
        int[] myarray5 = new int[] { 1, 2, 3 };

            GetRandom(myarray1);

        Console.ReadLine();
        }
    //从集合里面任意输出指定数量的随机数
    public static void GetRandom(int[] arr)//getrandom方法时间间隔较小
    {
        for (int i = 1; i < 500; i++)
        {
            Random ran1 = new Random();
            int m = ran1.Next(0, arr.Length);
            Console.WriteLine(arr[m]);

        }
    }
    static int add(int a, int b)
    {
        return a + b;
    }
}
}