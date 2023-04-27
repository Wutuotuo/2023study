#  C#入门
## 一、语法知识

### 1.程序语言是什么

用于人和计算机进行交流通过程序语言让计算机能够响应我们发出的指令。

- C：	嵌入式硬件开发

- C++:  游戏客户端，服务器，软件

- C#:	游戏客户端，服务器，软件，网站

- Java: 安卓，服务器，软件，网站

- JavaScript:H5游戏，网站，服务器

- PHP:  网站，服务器

- Python:网站，服务器，辅助开发

- SQL:  数据库

- Go:	服务器

- Objective-C: 苹果相关

- Swift: 苹果相关

### 2.开发环境搭建

搭建用于程序开发的环境，安装代码可以被电脑识别的软件

IDE 集成开发环境 一般包括了代码编辑，编译器，调试器。图形用户界面等等工具

常用的IDE软件

- Visual Studio:一般 Windows 操作系统使用的软件都由它来进行开发 ，可用于开发基于 C 、 C++ 、 C # 等等语言的软件
- Eclipse intelliJ IDEA:一般主要用于开发 Java 语言的相关软件
- Android Studio:谷歌推出 ，主要用于开发安卓应用
- Xcode:苹果推出 ，主要用于开发苹果应用

### 3.第一个应用程序

程序写在语句块中

被大括号包裹的部分称为语句块

不同语句块中书写的代码规则不同

```c#
using System;

namespace test
{
	//命名控件代码块
	class Program
	{
		//类代码块
		public static void Main(string[] args)
		{
			//函数代码块
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
输出：
    Hello World!
    Press any key to continue . . . 
```



### 4.变量

```
#region Myregion
折叠代码
#endregion
```

变量：存储各个类型数值的一个容器，可以通过‘+’来拼接，小数默认是double类型，需要float的话加f。

| 类型       | 举例                                                         |
| ---------- | ------------------------------------------------------------ |
| 整数类型   | sbyte（-128~127）、byte（0~255）、short（-32768~32767）、ushort（0~65535）、int（-21亿~21亿多）、uint（0~42亿）、long（-900万兆~900万兆）、ulong（0~1800万兆） 和 char（0~65535）,string (多个字符无上限) |
| 浮点型     | float（根据编译器不同存储7/8位有效数字） 和 double（存储15~17位有效数字，抛弃的数字会四舍五入） |
| 十进制类型 | decimal（存储27~28位有效数字，不建议使用）                   |
| 布尔类型   | true 或 false 值，指定的值                                   |
| 空类型     | 可为空值的数据类型                                           |

C# 允许定义其他值类型的变量，比如 **enum**，也允许定义引用类型变量，比如 **class**。

### 5.变量的本质

一个字节byte为8位bit

即1byte = 0000 0000

### 6.变量的命名规范

标识符是用来识别类、变量、函数或任何其它用户定义的项目。在 C# 中，类的命名必须遵循如下基本规则：

- 标识符必须以字母、下划线或 @ 开头，后面可以跟一系列的字母、数字（ 0 - 9 ）、下划线（ _ ）、@。
- 标识符中的第一个字符不能是数字。
- 标识符必须不包含任何嵌入的空格或符号，比如 ? - +! # % ^ & * ( ) [ ] { } . ; : " ' / \。
- 标识符不能是 C# 关键字。除非它们有一个 @ 前缀。 例如，@if 是有效的标识符，但 if 不是，因为 if 是关键字。
- 标识符必须区分大小写。大写字母和小写字母被认为是不同的字母。
- 不能与C#的类库名称相同。

### 7.常量

常量是固定值，程序执行期间不会改变。常量可以是任何基本数据类型，比如整数常量、浮点常量、字符常量或者字符串常量，还有枚举常量。

常量可以被当作常规的变量，只是它们的值在定义后不能被修改。

- 整数常量可以是十进制、八进制或十六进制的常量。前缀指定基数：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。

  整数常量也可以有后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。后缀可以是大写或者小写，多个后缀以任意顺序进行组合。

  ```c#
  212         /* 合法 */
  215u        /* 合法 */
  0xFeeL      /* 合法 */
  078         /* 非法：8 不是一个八进制数字 */
  032UU       /* 非法：不能重复后缀 */
  ```

- 一个浮点常量是由整数部分、小数点、小数部分和指数部分组成。您可以使用小数形式或者指数形式来表示浮点常量。

  这里有一些浮点常量的实例：
  
  ```c#
  3.14159       /* 合法 */
  314159E-5L    /* 合法 */
  510E          /* 非法：不完全指数 */
  210f          /* 非法：没有小数或指数 */
  .e55          /* 非法：缺少整数或小数 */
  ```

- 字符串常量是括在双引号 "" 里，或者是括在 @"" 里。字符串常量包含的字符与字符常量相似，可以是：普通字符、转义序列和通用字符

  使用字符串常量时，可以把一个很长的行拆成多个行，可以使用空格分隔各个部分。

  这里是一些字符串常量的实例。下面所列的各种形式表示相同的字符串。

  ```c#
  string a = "hello, world";                  // hello, world
  string b = @"hello, world";               // hello, world
  string c = "hello \t world";               // hello     world
  string d = @"hello \t world";               // hello \t world
  string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
  string f = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
  string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
  string h = @"\\server\share\file.txt";      // \\server\share\file.txt
  string i = "one\r\ntwo\r\nthree";
  string j = @"one
  two
  three";
  ```

---

- 常量是使用 **const** 关键字来定义的 。定义一个常量的语法如下：

  ```c#
  const <data_type> <constant_name> = value;
  ```

### 8.转义字符

- 字符常量是括在单引号里，例如，'x'，且可存储在一个简单的字符类型变量中。一个字符常量可以是一个普通字符（例如 'x'）、一个转义序列（例如 '\t'）或者一个通用字符（例如 '\u02C0'）。

  在 C# 中有一些特定的字符，当它们的前面带有反斜杠时有特殊的意义，可用于表示换行符（\n）或制表符 tab（\t）。在这里，列出一些转义序列码：

  | 转义序列   | 含义                       |
  | ---------- | -------------------------- |
  | \\         | \ 字符                     |
  | \'         | ' 字符                     |
  | \"         | " 字符                     |
  | \?         | ? 字符                     |
  | \a         | Alert 或 bell              |
  | \b         | 退格键（Backspace）        |
  | \f         | 换页符（Form feed）        |
  | \n         | 换行符（Newline）          |
  | \r         | 回车                       |
  | \t         | 水平制表符 tab             |
  | \v         | 垂直制表符 tab             |
  | \ooo       | 一到三位的八进制数         |
  | \xhh . . . | 一个或多个数字的十六进制数 |

### 9.类型转换

类型转换从根本上说是类型铸造，或者说是把数据从一种类型转换为另一种类型。在 C# 中，类型铸造有两种形式：

- **隐式类型转换** - 这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。

  ```c#
  long l = 1;
  int i = 1;
  l = i;//可以小范围的类型转换为大范围
  i = l;//报错，不能小范围的类型转换为大范围
  ```

  

- **显式类型转换** - 显式类型转换，即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。

  ```c#
  //强制转换 double 为 int
  i = (**int**)d;
  Console.WriteLine(i);
  Console.ReadKey();
  ```
  
    


C# 提供了下列内置的类型转换方法：

  | 序号 | 方法 & 描述                                                  |
  | ---- | ------------------------------------------------------------ |
  | 1    | **ToBoolean** 如果可能的话，把类型转换为布尔型。             |
  | 2    | **ToByte** 把类型转换为字节类型。                            |
  | 3    | **ToChar** 如果可能的话，把类型转换为单个 Unicode 字符类型。 |
  | 4    | **ToDateTime** 把类型（整数或字符串类型）转换为 日期-时间 结构。 |
  | 5    | **ToDecimal** 把浮点型或整数类型转换为十进制类型。           |
  | 6    | **ToDouble** 把类型转换为双精度浮点型。                      |
  | 7    | **ToInt16** 把类型转换为 16 位整数类型。                     |
  | 8    | **ToInt32** 把类型转换为 32 位整数类型。                     |
  | 9    | **ToInt64** 把类型转换为 64 位整数类型。                     |
  | 10   | **ToSbyte** 把类型转换为有符号字节类型。                     |
  | 11   | **ToSingle** 把类型转换为小浮点数类型。                      |
  | 12   | **ToString** 把类型转换为字符串类型。                        |
  | 13   | **ToType** 把类型转换为指定类型。                            |
  | 14   | **ToUInt16** 把类型转换为 16 位无符号整数类型。              |
  | 15   | **ToUInt32** 把类型转换为 32 位无符号整数类型。              |
  | 16   | **ToUInt64** 把类型转换为 64 位无符号整数类型。              |

 **实例**

```c#
**namespace** TypeConversionApplication
 {
   **class** StringConversion
   {
     **static** **void** Main(**string**[] args)
     {
       **int** i = 75;
       **float** f = 53.005f;
       **double** d = 2345.7652;
       **bool** b = **true**;
 
       Console.WriteLine(i.ToString());
       Console.WriteLine(f.ToString());
       Console.WriteLine(d.ToString());
       Console.WriteLine(b.ToString());
       Console.ReadKey();
       
     }
   }
 }
```



### 10.异常捕获

异常捕获可以避免代码报错造成程序卡死的情况

```c#
public static void Main(string[] args)

​    {

​      Console.WriteLine("异常捕获");

​      try

​      {

​        string str = Console.ReadLine();

​        int i = int.Parse(str);

​        Console.WriteLine(i);

​        Console.Read();

​        //希望进行异常捕获的代码块

​        //放到try中

​        //如果try中的代码报错了不会让程序卡死

​      } 

​      catch (Exception e)

​      {

​        Console.WriteLine(e);

​        Console.WriteLine("请输入合法数字");

​        Console.Read();

​        //e就是try里面的具体问题，可以使用e去打印问题

​        //如果出错了会执行catch中的代码来捕获异常

​        throw;

​      }

​      //可选部分

​      finally

​      {

​        Console.WriteLine("执行完毕");

​      }

​      //注意异常捕获代码基本结构不需要加分号，语句块需要加分号
```



### 11.运算符

- 赋值符号

  ​	“`=` ”将右侧的值赋给左侧

- 算术运算符

​		`+ - * / %`加减乘除取余

- 算数运算符的优先级

  ​	先算乘除取余，再算加减，有括号先括号

- 算术运算符的复合运算符

  ​	`+= -= *=  /=`	用于自己参加运算

- 算数运算符的自增减

  ​	`a++` 先用再加

  ​	`++a`  先加再用

- 字符串拼接

  1.使用加号 “`+`” 进行字符串拼接

  2.使用加号 “`+=`” 进行字符串拼接

  ```c#
  //字符串后面的都变成字符，加括号可以先运算
  str1 = 1+2+3+4 		//输出10
  
  str2 = ""+1+2+3+4	//输出1234
      
  str3 = 1+2+""+3+4	//输出334
  
  str4 = (1+2)+""+(3+4)	//输出37
  ```

  3.使用`string.Format("待拼接的内容",内容1,内容2,```)`，想要拼接的内容用占位符替代，数字：0~n 依次往后

  ```c#
  string str = string.Format("我是{0}，我今年{1}岁","大学生",12)	//输出 我是大学生，我今年12岁
  ```

  4.控制台打印（和string.Format类似）

  ```c#
  console.WriteLine("我是{0}，我今年{1}岁","大学生",12)	//输出 我是大学生，我今年12岁
  console.Write("我是{0}，我今年{1}岁","大学生",12)	//输出 我是大学生，我今年12岁 
  ```

- 条件运算符
	
	`> < = >= <= != ==`
	
	不同数值类型之间可以随意进行比较，特殊类型char string bool只能同类型进行==和!=比较
	
	（在隐式转换中char（ASCII）可以和数值进行比较,还可以和其他char进行><比较）
	
- 逻辑运算符

  `&&` 逻辑与

  `||` 逻辑或

  `!`  逻辑非

  逻辑非优先级>逻辑与优先级>逻辑或优先级

  逻辑运算符优先级<算术运算符优先级

  > 逻辑运算符短路规则 在||和&&中，若已经满足了左边的内容将不再执行右边的内容
  >
  
- 位运算符
  主要是用数值类型进行计算，先将数值转换为2进制，在进行位运算

  1.位与& 同1为1

  ```
  int a = 1;		//001
  int b = 5;		//101
  int c = a & b ;	//001
  ```

  多个数值进行计算时,从左到右，依次计算

  2.位或| 有1为1

  3.异或^ 相同为0不同为1

  4.取反~ 0变1 1变0

  5.左移 左移几位右侧加几个零

  6.右移 右移几位右侧去掉几个数

- 三目运算符
  空位1?空位2:空位3

  bool类型?bool为真时返回内容:bool为假时返回内容

### 12.条件分支语句

让顺序执行的代码产生逻辑分支

- if

  ~~~c#
  if("条件"){}
  if("条件"){}else{}
  if("条件"){}else if{"条件"}else
  ```
  ~~~

- switch

  ```
  switch()
  {
  	case 常量:
  	{
  	代码;
  	break;
  	}
  	case 常量:
  	{
  	代码;
  	break;
  	}
  	default://如果上方case条件都不满足，就会执行default中的代码。
  	{
  	代码;
  	break;
  	}
  }
  ```

### 13.循环语句

- while循环

  ```c#
  while(condition)
  {
     statement(s);
  }
  ```

  在这里，**statement(s)** 可以是一个单独的语句，也可以是几个语句组成的代码块。**condition** 可以是任意的表达式，当为任意非零值时都为真。当条件为真时执行循环。只要给定的条件为真，C# 中的 **while** 循环语句会重复执行一个目标语句。

- do while循环

  ```c#
  do
  {
     statement(s);
  
  }while( condition );
  ```

  - 不像 **for** 和 **while** 循环，它们是在循环头部测试循环条件。**do...while** 循环是在循环的尾部检查它的条件。

  - **do...while** 循环与 while 循环类似，但是 do...while 循环会确保至少执行一次循环。

- for循环

  ```c#
  for ( init; condition; increment )
  {
     statement(s);
  }
  ```

  1. **init** 会首先被执行，且只会执行一次。这一步允许您声明并初始化任何循环控制变量。您也可以不在这里写任何语句，只要有一个分号出现即可。

  2. 接下来，会判断 **condition**。如果为真，则执行循环主体。如果为假，则不执行循环主体，且控制流会跳转到紧接着 for 循环的下一条语句。

  3. 在执行完 for 循环主体后，控制流会跳回上面的 **increment** 语句。该语句允许您更新循环控制变量。该语句可以留空，只要在条件后有一个分号出现即可。

  4. 条件再次被判断。如果为真，则执行循环，这个过程会不断重复（循环主体，然后增加步值，再然后重新判断条件）。在条件变为假时，for 循环终止。

- foreach循环

  ```c#
  foreach (var item in collection)
  {
     statement(s);
  }
  ```

  collection 是要遍历的集合，item 是当前遍历到的元素。

  以下实例有三个部分：

  - 通过 foreach 循环输出整型数组中的元素。 
  - 通过 for 循环输出整型数组中的元素。 
  - foreach 循环设置数组元素的计算器。
  -  foreach 循环可以用来遍历集合类型，例如数组、列表、字典等

### 14.控制台相关方法

- Clear：清空屏幕上输出的全部内容

  ```cs
  Console.WriteLine("下面会进行清空");
  //1、清空上方全部内容
  Console.Clear();
  Console.WriteLine("上面进行了清空");
  ```

- SetWindowSize：设置窗口的大小

- SetBufferSize：设置缓冲区的大小

  > **注意：**
  >  控制台大小分为窗口大小和缓冲区大小
  >
  > ​    1、先设置窗口的大小，再设置缓冲区的大小
  > ​    2、窗口的大小和缓冲区的大小不能大于控制台的最大尺寸
  > ​    3、缓冲区的大小不能小于窗口的大小 

  ```c#
      //窗口大小（程序运行后能看到的控制面板的大小）
      Console.SetWindowSize(100, 50);//（x,y）
      //设置缓冲区的大小（缓冲区大小等于窗口大小加上滚动条后面的大小）
      Console.SetBufferSize(200, 100);//(x,y)
  ```

  

- SetCursorPosition：设置光标的位置

  > **注意：**
  >
  > - 控制台左上角是坐标的原点（0,0），右侧是x轴的正方向，下侧是y轴的正方向；是一个平面二位坐标系。
  > - 注意：边界问题（最好不要设置负数）、横纵距离单位不同1y=2x。 
  ```c#
          //设置光标位置为x=10，y=5；
    Console.SetCursorPosition(10, 5);
    Console.WriteLine("设置光标的位置在（10,5）");
  ```
  


- ForegroundColor：设置前景色

- BackgroundColor：设置背景色

  > **注意：**
  >
  > 设置前景色：从设置之后开始，改变输出内容的颜色；
  >
  > 设置背景色：改变背景颜色，这里需要重点注意的是，只是进行简单的设置不会改变全部的背景色，需要使用一次Clea[r方](https://so.csdn.net/so/search?q=r方&spm=1001.2101.3001.7020)法。（个人认为原因是：上面已经输出的内容调用了系统默认的背景色（黑色），只有在重新设置的背景色之后输出的内容才会改变背景的颜色；所以在没有内容输出的空白部分在设置背景色之前就已经调用了系统的默认黑色进行了空白输出，就会显示黑色。（设置背景色：只是设置输出内容的背景色，空白也是输出内容））

  ```c#
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("上面将前景色设置为红色");
  //设置背景色
  Console.BackgroundColor = ConsoleColor.Yellow;
  //Clear：将上面的内容清空后，背景色才能铺展开
  Console.Clear();
  Console.WriteLine("重置背景色需要将上面的内容Clear一次，才能把整个背景色改变");
  ```

- CursorVisible：设置光标的显隐

  ```c#
  //5、光标的显隐
  Console.CursorVisible = false;
  Console.WriteLine("将光标进行了隐藏");
  ```

  > 当为false时，就会隐藏光标；为true时就会显示光标跳动。

- Environment.Exit(0):关闭当前进程，关闭窗口

  ```c#
  //6、关闭控制台
  Environment.Exit(0);//参数为零，代表该进程完成
  ```
  
  > 参数为0（这里我不知道参数能不能为1），代表该进程全部执行完毕，会关闭当前窗口（在调试模式下不会关闭，发行版可以关闭）。

### 15.随机数

```c#
namespace System
{
    public class Random
    {
        public Random();
        public Random(int Seed);<br>
        public virtual int Next();
        public virtual int Next(int minValue, int maxValue);
        public virtual int Next(int maxValue);
        public virtual void NextBytes(byte[] buffer);
        public virtual double NextDouble();
        protected virtual double Sample();
    }
}
```

- Random();

  这是无参构造方法，比如在程序中这样写：

  ```c#
  Random a = new Random();
  ```

  得到的a就是一个随机数生成器，它可以用来生成随机数。

- int Next();

  这个方法返回值为int类型，调用它就能得到一个随机数，反复调用就能反复得到随机数。

  示例：

  ```c#
  static void Main(string[] args)
  {
      Random a = new Random();
      for (int i = 0; i < 10; i++)
      {
          Console.WriteLine(a.Next());
      }
   
      Console.ReadKey();
  }
  ```

  这样就可以获得10个随机数

  ![](../image/Snipaste_2023-04-27_11-07-36.png)

  >  **注意**：虽然看上去Next方法返回值是int类型，但实际上它只返回非负整数，而且不包括int类型能表示的最大的那个整数（2^31 - 1）

- int Next(int minValue, int maxValue);

  这个方法能指定随机数的生成范围，左闭右开区间，即生成的数能包含minValue，不包含maxValue。可以包含负数。但是maxValue的值不能大于minValue的值，否则运行时会抛出异常。

- int Next(int maxValue);

  这个方法指定随机数的最大值（不包含maxValue），并且它也只能生成非负整数，与Next(0, maxValue)是一个道理，如果传入的maxValue为负数，那么运行时抛出异常，如果maxValue的值为0或1，那么生成的随机数只能是0。

- double NextDouble();

  这个方法能返回一个大于或等于 0.0 且小于 1.0 的随机浮点数。

- void NextBytes(byte[] buffer);

  这个方法传入指定长度的byte类型的数组，用byte类型的随机数填充数组，如：

  ```c#
  static void Main(string[] args)
  {
      Random a = new Random();
      byte[] b = new byte[10];
   
      a.NextBytes(b);
      foreach(byte i in b)
      {
          Console.WriteLine(i);
      }
   
      Console.ReadKey();
  }
  ```

  ![](../image/Snipaste_2023-04-27_11-11-31.png)

- double Sample();

  这个方法比较特殊，从声明可以看出来，其他的方法权限都是public，这个方法是protected。从方法的描述上能看到，这个方法返回的也是大于或等于 0.0 且小于 1.0 的随机浮点数，它与NextDouble看上去似乎只是权限不一样，看了下面这段代码就知道了：

  ```c#
  namespace sdq
  {
      class MyRandom : Random
      {
          protected override double Sample()
          {
              return 0.125;
          }
      }
      class Program
      {
          static void Main(string[] args)
          {
              MyRandom a = new MyRandom();
   
              for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine(a.NextDouble());
              }
              Console.ReadKey();
          }
      }
  }
  ```

  代码分析：

  　　首先定义了一个类MyRandom，继承至Random，由于Random中的Sample()是虚方法，因此可以在派生类中将Sample()重写，我在这里是将它固定返回0.125。在Main方法中构造了a这个对象，并且调用了a.NextDouble()去生成10个随机数，运行结果如下：

  ![](../image/Snipaste_2023-04-27_11-14-39.png)

  从结果可以看出来，Random的Sample方法可以改变NextDouble()方法的行为，如果用户想自定义获取随机数的方法，则可以通过重写Sample来实现。

- Random(int Seed);

  最后再说一下这个带参构造函数，它用来在构造对象时指定随机数生成器的种子，而不带参的构造函数则是以时间作为种子。至于种子是个什么东西，我也不知道，通过下面这个例子也许能说明：

  ```c#
  using System;
  using System.Threading;
   
  namespace test
  {
      class Program
      {
          static void Main(string[] args)
          {
              Random a = new Random(123);
              Thread.Sleep(1000);
              Random b = new Random(123);
   
              for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine("{0}\t{1}", a.Next(), b.Next());
              }
              Console.ReadKey();
          }
      }
  }
  ```

  运行结果如下：

  ![](../image/Snipaste_2023-04-27_11-17-08.png)

  可见a对象和b对象是使用相同的种子123构造出来的，之后它们每次生成的随机数的值都是一样的。而如果使用默认的构造方法（以时间为种子）则不会有这种情况。

  注：之所以调用Thread.Sleep(1000);是为了错开两次构造随机数对象的时间，如果不这么做的话，使用默认构造方法，连续两次调用Random()得到的结果仍然可能会一样，因为两次调用Random()时的时间是一样的。

  我还没有去研究过windows系统时间的最小单位，按一般经验判断可能是us，想想1us内调用两次构造方法时间是够够的吧。

# C#基础

## 一、语法知识

### 1.复杂数据类型



### 2.数值型和引用类型

### 3.函数

### 4. 结构体

### 5. 初级排序

## 二、实践项目

### 1.需求分析

### 2.控制台基础设置

### 3.多个场景

### 4.开始逻辑实现

### 5.游戏场景逻辑实现

### 6.结束场景逻辑实现

# C#核心

## 一、语法知识

### 1.面对对象的概念

### 2. 面对对象-封装

### 3. 面对对象-继承

### 4.面对对象-多态

### 5.面对对象相关知识点

## 二、实践项目

### 1.多个脚本文件

### 2.Uml类图

### 3.七大原则

### 项目-需求分析

#### 游戏对象与场景更新接口

#### 实现多场景切换

#### 游戏场景逻辑实现

# C#进阶

## 一、语法知识

### 1.简单数据结构类

#### Arraylist

#### Stack

#### Queue

#### Hashtable

### 2.泛型

### 3.常用泛型数据结构类

### 4.委托和事件

### 5. 匿名函数

### 6.Lambad表达式

### 7.List排序

### 8.协变逆变

### 9.多线程

### 10.预处理器指令

###  11.反射和特性

### 12.迭代器

### 13. 特殊语法

### 14.排序进阶

## 二、实践项目

### 1.需求分析

### 2.复用修改贪吃蛇部分代码

### 3.绘制对象基类和类型枚举

### 4.地图类不变墙壁和动态墙壁相关

### 5.方块变形信息类

### 6.方块管理者类初始化方块

### 7.方块变形

### 8.方块左右移动

### 9.方块自动向下移动

### 10.输入线程

### 11.消方块

### 12.结束流程

### 13.优化线程