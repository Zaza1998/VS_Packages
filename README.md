# VS_Packages
 VS高版本向低版本兼容
 Sql Sever Management Studio
 VS的解决方案，一个解决方案包括多个项目，一个项目包括多个文件，并且文件时分类型的。
 C#里面的文件是以.cs结尾的，一个.cs文件中可以有一个名称空间（name space），一个名称空间里面可以有多个类（class），一个类里面有多个属性（方法、接口），方法中式实现方法的详细程序。

 引用文件时当前项目所需要的.net 模块（类库）。
 .cs ->编译->.dll

 一个.net工程里面有且仅有一个包含Main的文件。
变量命名：一般以字母开头，‘_’、’@‘ 属于特殊类型的开头。后面跟任意字母、字符、数字；变量不可以重复定义；camel命名规范（第二个单词首字母大写）、pascal命名法（首字母大写）；变量命名应该有语义，英文单词的缩写用大写。
 .net franmework 可以搜索方法理解该方法的使用。

变量的分类：
	值类型（可以暂时不分配空间）：
		简单类型：整型、double、bool\char\string\enum\struct
	复合类型：枚举、结构型
		引用类型（需立即分配命名空间）：
			类：
			数组：
			接口:		
			委托

 C#采用的编码类型是Unicode；
 Unicode中一个字符占两个字节，一个字节占8位；
 Int a = 10;,b = 20;
 haha：= a & b;
 (a 和b 按位想与)

数组内的数据类型相同且声明数组后必须对数组进行实例化：int array[] = new int[3];

枚举类型：enum语句	

//Structure Type 写在类中，是一种轻量的类
            struct ComplexNum
        {
            public double a;
            public double b;
        }

引用类型的改变，一改具改（class）；值类型的改变，只改当前赋值（struct）

接口不能使用静态（static）等修饰符，如要修饰，应在类中实现。接口是对i想的泛化，接口的使用是对接口的细化，即写出具体的方法。

类型转换：
	隐式转换：不需要用户操作，用赋值符号赋值，将精度高的赋值给精度低的，系统自动转换；不包括Boolean 和char转换
	显示转换：
		高精度向低精度数值的转换； 
			int y = (int)x;
			int y = converet.ToInt32(x);
		数值向string转换：
			double x = 3.14;
			string y = x.toString();
		string向数值转换：
			string x = 1;
			int y  = int.Prase(x);
		引用类型之间的转换
			由范围广的转向范围窄的不需要操作，系统自动操作；
			由范围窄的转向范围广的，需要用‘（）’进行显式转换；
		装箱转换(值类型向引用类型)：
			int x = 3;
			object y =x;
		拆箱转换（引用类型向值类型）：
			int z = (int)obj;
控制结构


