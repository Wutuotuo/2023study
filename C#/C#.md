#  C#入门

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

### 1.复杂数据类型

- 枚举

  枚举是一组命名整型常量。枚举类型是使用 **enum** 关键字声明的。

  C# 枚举是值类型。换句话说，枚举包含自己的值，且不能继承或传递继承。

  ```c#
  enum <enum_name>
  { 
      enumeration list 
  };
  ```

  其中，

  - *enum_name* 指定枚举的类型名称。
  - *enumeration list* 是一个用逗号分隔的标识符列表。

  枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。默认情况下，第一个枚举符号的值是 0.例如：

  ```c#
  enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
  ```

- 数组

  数组是一个存储相同类型元素的固定大小的顺序集合。数组是用来存储数据的集合，通常认为数组是一个同一类型变量的集合。

  声明数组变量并不是声明 number0、number1、...、number99 一个个单独的变量，而是声明一个就像 numbers  这样的变量，然后使用 numbers[0]、numbers[1]、...、numbers[99]  来表示一个个单独的变量。数组中某个指定的元素是通过索引来访问的。

  所有的数组都是由连续的内存位置组成的。最低的地址对应第一个元素，最高的地址对应最后一个元素。

  ```c#
  datatype[] arrayName;
  ```

  其中，

  - *datatype* 用于指定被存储在数组中的元素的类型。
  - *[ ]* 指定数组的秩（维度）。秩指定数组的大小。
  - *arrayName* 指定数组的名称。

  例如：

  ```c#
  double[] balance;
  ```

  初始化数组

  声明一个数组不会在内存中初始化数组。当初始化数组变量时，您可以赋值给数组。

  数组是一个引用类型，所以您需要使用 new 关键字来创建数组的实例。

  例如：

  ```c#
  double[] balance = new double[10];//声明数组
  balance[0] = 4500.0;//数组赋值
  double[] balance = { 2340.0, 4523.69, 3421.0};//声明数组的同时给数组赋值
  int [] marks = new int[5]  { 99,  98, 92, 97, 95};//创建并初始化一个数组
  int [] marks = new int[]  { 99,  98, 92, 97, 95};//也可以省略数组的大小
  //您也可以赋值一个数组变量到另一个目标数组变量中。在这种情况下，目标和源会指向相同的内存位置：
  int [] marks = new int[]  { 99,  98, 92, 97, 95};
  int[] score = marks;
  ```

  >  当您创建一个数组时，C# 编译器会根据数组类型隐式初始化每个数组元素为一个默认值。例如，int 数组的所有元素都会被初始化为 0。

  多维数组

  C# 支持多维数组。多维数组又称为矩形数组。

  例如

  ```c#
  string [,] names;//声明一个 string 变量的二维数组
  int [ , , ] m;//声明一个 int 变量的三维数组
  
  int [,] a = new int [3,4] {
   {0, 1, 2, 3} ,   /*  初始化索引号为 0 的行 */
   {4, 5, 6, 7} ,   /*  初始化索引号为 1 的行 */
   {8, 9, 10, 11}   /*  初始化索引号为 2 的行 */
  };
  ```

  交错数组

  交错数组是数组的数组，同时也是一维数组。

  例如

  ```c#
  int[][] scores = new int[5][];
  for (int i = 0; i < scores.Length; i++) //声明交错数组
  {
     scores[i] = new int[4];
  }
  int[][] scores = new int[2][]{new int[]{92,93,94},new int[]{85,66,87,88}};//初始化
  //其中，scores 是一个由两个整型数组组成的数组 -- scores[0] 是一个带有 3 个整数的数组，scores[1] 是一个带有 4 个整数的数组。
  ```

- 结构体

  在 C# 中，结构体是值类型数据结构。它使得一个单一变量可以存储各种数据类型的相关数据。**struct** 关键字用于创建结构体。

  结构体是用来代表一个记录。假设您想跟踪图书馆中书的动态。您可能想跟踪每本书的以下属性：

  - Title
  - Author
  - Subject
  - Book ID

定义结构体 

```c#
struct Books
{
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  
```

用法

```c#
using System;
using System.Text;
     
struct Books
{
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class testStructure
{
   public static void Main(string[] args)
   {

      Books Book1;        /* 声明 Book1，类型为 Books */
      Books Book2;        /* 声明 Book2，类型为 Books */

      /* book 1 详述 */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali";
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 详述 */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;

      /* 打印 Book1 信息 */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* 打印 Book2 信息 */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);      

      Console.ReadKey();

   }
}
```

特点

在 C# 中的结构与传统的 C 或 C++ 中的结构不同。C# 中的结构有以下特点：

- 结构可带有方法、字段、索引、属性、运算符方法和事件。

- 结构可定义构造函数，但不能定义析构函数。但是，您不能为结构定义无参构造函数。无参构造函数(默认)是自动定义的，且不能被改变。

- 与类不同，结构不能继承其他的结构或类。

- 结构不能作为其他结构或类的基础结构。

- 结构可实现一个或多个接口。

- 结构成员不能指定为 abstract、virtual 或 protected。

- 当您使用 **New** 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。

- 如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。

  > tip:
  >
  > 类和结构有以下几个基本的不同点：
  >
  > - 结构是值类型，类是引用类型。
  > - 结构不支持继承。
  > - 结构不能声明默认的构造函数。
  > - 结构体中声明的字段无法赋予初值，类可以:
  > - 结构体的构造函数中，必须为结构体所有字段赋值，类的构造函数无此限制:
  > - 结构是值类型，它在栈中分配空间；而类是引用类型，它在堆中分配空间，栈中保存的只是引用。

### 2.数值型和引用类型

引用类型：string，数组，类

值类型：其他

- 区别

  ```c#
  int a = 10;
  int b = a;
  int [] arr1 = new int[4]  {1,2,3,4};
  int [] arr2 = arr1;
  Console.WriteLine("a={0},b={1}",a,b);
  //输出a=10,b=10
  Console.WriteLine("arr1[0]={0},arr2[0]={1}",arr1[0],arr2[0]);
  //输出arr[0]=1,arr2[0]=1;
  b = 5;
  arr2[0] = 5;
  Console.WriteLine("a={0},b={1}",a,b);
  //输出a=10,b=5
  Console.WriteLine("arr1[0]={0},arr2[0]={1}",arr1[0],arr2[0]);
  //输出arr[0]=5,arr2[0]=5;
  ```

  不难发现，值类型在相互赋值时，把内容拷贝给了对方，而引用类型的相互赋值时，是让两者指向同一个值 

  原因为存储方式不同，值类型存储在栈（系统分配比较小但是快），引用类型存储在堆上（手动申请和释放，大而慢）

  ![](../image/Snipaste_2023-04-27_12-22-58.png)

特殊的引用类型string

​	因为C#对字符串的特殊处理使它具有值类型的特点，当重新赋值时会在堆上重新分配空间

​	![](../image/Snipaste_2023-04-27_12-32-33.png)

> **注意：**string虽然方便，但频繁重新赋值时，会产生内存垃圾

### 3.函数

- 函数基础

  ```c#
  <Access Specifier> <Return Type> <Method Name>(Parameter List)
  {
     Method Body
  }
  ```

  下面是方法的各个元素：

  - **Access Specifier**：访问修饰符，这个决定了变量或方法对于另一个类的可见性。
  - **Return type**：返回类型，一个方法可以返回一个值。返回类型是方法返回的值的数据类型。如果方法不返回任何值，则返回类型为 **void**。
  - **Method name**：方法名称，是一个唯一的标识符，且是大小写敏感的。它不能与类中声明的其他标识符相同。
  - **Parameter list**：参数列表，使用圆括号括起来，该参数是用来传递和接收方法的数据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说，一个方法可能不包含参数。
  - **Method body**：方法主体，包含了完成任务所需的指令集。

- ref和out

  在C#中通过使用方法来获取返回值时，通常只能得到一个返回值。因此，**当一个方法需要返回多个值的时候，就需要用到ref和out**，

  **同时也可以在函数内部，改变传入的参数的值**。

  若要使用 ref 和out参数，则方法定义和调用方法都必须显式使用 ref和out 关键字。在方法中对参数的设置和改变将会直接影响函数调用之处(参数的初始值）。

  > ref指定的参数在 **函数调用前必须初始化**，在内部可改可不改
  >
  > out指定的参数在不用初始化，**但在函数内部（即方法中）赋初值。**

  正确使用ref：

  ```c#
  class Program
      {
          static void Main(string[] args)
          {
              int x = 10;
              int y = 20;
              GetValue(ref x, ref  y);
              Console.WriteLine("x={0},y={1}", x, y);//输出x=333,y=444
              Console.ReadLine();
          }
          public void GetValue(ref int x, ref int y)
          {
              x = 333;
              y = 444;
          }
      }
  ```

  错误使用ref:

  ```
  class Program
      {
          static void Main(string[] args)
          {
              int x ;//未进行初始化，报错
              int y ;//未进行初始化，报错
              GetValue(ref x, ref  y);
              Console.WriteLine("x={0},y={1}", x, y);
              Console.ReadLine();
          }
          public void GetValue(ref int x, ref int y)
          {
              x = 333;
              y = 444;
          }
      }
  ```

  > 总结：使用ref 必须在 **调用方法前** 对其进行**初识化操作**

  正确使用out：

  ```
  class Program
  {
      static void Main(string[] args)
      {
          int x = 10;
          int y = 233;
          Swap(out x, out y);
          Console.WriteLine("x={0},y={1}", x, y);//输出x=333,y=444
          Console.ReadLine();
      }
  
      public static void Swap(out int a, out int b)
      {
          a = 333;   //对a,b 在方法内进行了初识化，不会报错
          b = 444;
      }
  }
  ```

  错误使用out:

  ```
  class Program
  {
      static void Main(string[] args)
      {
          int x = 10;
          int y = 233;
          Swap(out x, out y);
          Console.WriteLine("x={0},y={1}", x, y);
          Console.ReadLine();
      }
  
      public static void Swap(out int a, out int b)
      {
      	int tmp = a;
          a = b;   //a,b在函数内部没有赋初值，则出现错误。
          b = tmp;
      }
  }
  ```

  > 总结：out 的使用必须要在 **方法内** 进行 **初始化** ，才不会报错

- 变长参数和参数默认值

  比如要计算n个整数的和

  ```c#
  int SumInt(int a,int b, ......)//如果有n个参数就无法实现了
  ```

  变长参数关键字params

  ```c#
  int SumInt(params int[] arr)
  {
     	int sum;
  	foreach(int i in arr)
      {
          sum +=i;
      }
      return sum;
  }
  ```

  > params 关键字后面必为数组，数组的类型可以使任意类型，函数参数中最多出现一个params参数且在最后出现，前面可以有n个其他参数。

  参数默认值

  ​	如果在函数的参数处给形参赋值，则不输入实参时，默认为形参的值。

- 函数重载

  ​	和函数类型无关，名字相同，参数数量不同或者参数类型或顺序不同，命名一组功能相似的函数，减少函数名的数量，避免命名控件的污染，同时提升程序的可读性。

  > ref和out，params可以算作重载 ，ref和out不能同时重载，可选参数不算重载

- 递归函数

  让函数自己调用自己

  1.必须有结束调用的条件

  2.必须能够达到结束的目的

### 4. 初级排序

- 冒泡排序

  冒泡排序是比较基础的排序算法之一，其思想是相邻的元素两两比较，较大的数下沉，较小的数冒起来，这样一趟比较下来，最大(小)值就会排列在一端。整个过程如同气泡冒起，因此被称作冒泡排序。
   冒泡排序的步骤是比较固定的：
   1>比较相邻的元素。如果第一个比第二个大，就交换他们两个。
   2>每趟从第一对相邻元素开始，对每一对相邻元素作同样的工作，直到最后一对。
   3>针对所有的元素重复以上的步骤，除了已排序过的元素(每趟排序后的最后一个元素)，直到没有任何一对数字需要比较。

  ```c#
  using System;
  using System.Threading;
   
  namespace Sort
  {
      class Program
      {
          static void Main(string[] args)
          {
              
              int[] arr = {23, 44, 66, 76, 98, 11, 3, 9, 7};
              Console.WriteLine("排序前的数组：");
              foreach (int item in arr)
              {
                  Console.Write(item + ",");
              }
              Console.WriteLine();
              BubbleSort(arr);
              Console.WriteLine("排序后的数组：");
              foreach (int item in arr)
              {
                  Console.Write(item+",");
              }
              Console.WriteLine();
              Console.ReadKey();
          }
          static void BubbleSort(int[] arr)
          {
          	int temp = 0;
              for (int i = 0; i < arr.Length - 1; i++)
              {
                  for (int j = 0; j < arr.Length - 1 - i; j++)
                  {
                      if (arr[j] > arr[j + 1])
                      {
                          temp = arr[j + 1];
                          arr[j + 1] = arr[j];
                          arr[j] = temp;
                      }
                  }
              }
          }
      }
  }
  ```
  
  每一次循环产生一个最大数排到最后面，因此内循环中比较N-1-i次
  
  i为最大数的数量，外循环是N-1剩出来最右边的最大数
  
- 选择排序

  选择排序是寻找当前数组中的最小元素/最大元素，然后将他们放到最前边/最后边的位置上去，然后以此类推，在剩余的数组中再次寻找，直到全部待排序的数据元素的个数为零。

  ```c#
  using System;
  using System.Threading;
   
  namespace Sort
  {
      class Program
      {
          static void Main(string[] args)
          {
              
              int[] arr = {23, 44, 66, 76, 98, 11, 3, 9, 7};
              Console.WriteLine("排序前的数组：");
              foreach (int item in arr)
              {
                  Console.Write(item + ",");
              }
              Console.WriteLine();
              SelectionSort(arr);
              Console.WriteLine("排序后的数组：");
              foreach (int item in arr)
              {
                  Console.Write(item+",");
              }
              Console.WriteLine();
              Console.ReadKey();
          }
          static void SelectionSort(int[] arr)
          {
              for (int i = 0; i < arr.Length - 1; i++)
          	{
          		int minIndex = i;
          		int minValue = arr[i];
          		for(int j = i + 1 ;j < arr.Length ;j++)
          		{
          			if(arr[j]<minValue)
          			{
          				minIndex = j;
          				minValue = arr[j];
          			}
          		}
          		arr[minIndex] = arr[i];
          		arr[i] = minValue;
          	}
          }
      }
  }
  ```

  内循环从第二个数开始和第一个数比较，在遍历一遍后找到最小的数，放到最左边

# C#核心

### 1.面对对象的概念

- 面向过程编程
  是一种以过程为中心的编程思想，分析出解决问题所需要的步骤，然后用函数把步骤一步一步实现，使用的时候一个一个依次调用

- 面向对象编程

  面向对象是一种对现实世界理解和抽象的编程方法，把相关的数据和方法组织为一个整体来看待，从更高的层次来进行程序开发，更贴近事物的自然运行模式特点

- 特点

  提高代码复用率
  提高开发效率
  提高程序可拓展性
  清晰的逻辑关系

- 关键字class

  三大特性：封装、继承、多态

  七大原则：开闭原则 、 依赖倒转原则 、 里氏替换原则 、 单一职责原则、接口隔离原则 、 合成复用原则 、 迪米特法则
### 2. 面对对象-封装

用程序语言形容对象

- 类和对象

  类的定义:一般是声明在namespace中，是以关键字 **class** 开始，后跟类的名称。类的主体，包含在一对花括号内。下面是类定义的一般形式：

  ```
  <access specifier> class  class_name
  {
      // member variables //成员变量
      <access specifier> <data type> variable1;
      <access specifier> <data type> variable2;
      ...
      <access specifier> <data type> variableN;
      // member methods //成员方法
      <access specifier> <return type> method1(parameter_list)
      {
          // method body
      }
      <access specifier> <return type> method2(parameter_list)
      {
          // method body
      }
      ...
      <access specifier> <return type> methodN(parameter_list)
      {
          // method body
      }
  }
  ```

> 请注意：
>
> - 访问标识符 <access specifier> 指定了对类及其成员的访问规则。如果没有指定，则使用默认的访问标识符。类的默认访问标识符是 **internal**，成员的默认访问标识符是 **private**。
> - 帕斯卡命名法，即每个单词的首字母大写。同一个语句块中不能重名。
> - 数据类型 <data type> 指定了变量的类型，返回类型 <return type> 指定了返回的方法返回的数据类型。
> - 如果要访问类的成员，你要使用点（.）运算符。
> - 点运算符链接了对象的名称和成员的名称。

​	对象的定义：通过类创建出来的，相当于声明一个指定类的变量，创建的过程称为实例化对象，类对象都是引用类型

​	实例化对象的方法：

```c#
class Person
{

}
Person p1;					//已经在栈上分配空间，但地址指向空，即没有分配内存空间（一般指没有在堆上分配空间为没有分配内存空间）
Person p2 = null;			//已经在栈上分配空间，但地址指向空，即没有分配内存空间（一般指没有在堆上分配空间为没有分配内存空间）
Person p3 = new Person();	//分配空间，栈指向堆（引用类型）
```

- 成员变量和访问修饰符

  - 成员变量

    1.声明在类语句块中

    2.用来描述对象的特征

    3.可以使任意变量类型

    4.数量不做限制

    5.是否赋值根据需求来定

    ```c#
    enum E_SexType
    {
    	Man,
    	Woman
    }
    struct Position{}
    class Pet{}
    class Person
    {
    	public string name = "张三";//任意变量类型
    	int age;
    	E_SexType sex;//枚举
        //如果要在类中声明一个和自己相同类型的成员变量时不能对他进行实例化
    	Person gridFriend;//类 
    	Person[] boyFriend;//类
    	Position pos;//结构体
    	Pet pet;//类
    }
    //成员变量的使用 , 使用.来访问 可以访问的 成员变量和方法
    //值类型默认值都为0 , bool类型为false , 引用类型为null
    Person p = new Person();
    p.name = "名字";
    ```

  - 访问修饰符

    所有类型和类型成员都具有可访问性级别。 该级别可以控制是否可以从你的程序集或其他程序集中的其他代码中使用它们。 [程序集](https://learn.microsoft.com/zh-cn/dotnet/standard/glossary#assembly)是通过在单个编译中编译一个或多个 .cs 文件而创建的 .dll 或 .exe。 可以使用以下访问修饰符在进行声明时指定类型或成员的可访问性：

    - [public](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/public)：同一程序集中的任何其他代码或引用该程序集的其他程序集都可以访问该类型或成员。 某一类型的公共成员的可访问性水平由该类型本身的可访问性级别控制。

    - [private](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/private)：只有同一 `class` 或 `struct` 中的代码可以访问该类型或成员。

    - [protected](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/protected)：只有同一 `class` 或者从该 `class` 派生的 `class` 中的代码可以访问该类型或成员。

    - [internal](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/internal)：同一程序集中的任何代码都可以访问该类型或成员，但其他程序集中的代码不可以。 换句话说，`internal` 类型或成员可以从属于同一编译的代码中访问。

    - [protected internal](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/protected-internal)：该类型或成员可由对其进行声明的程序集或另一程序集中的派生 `class` 中的任何代码访问。

    - [private protected](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/private-protected)：该类型或成员可以通过从 `class` 派生的类型访问，这些类型在其包含程序集中进行声明。

      ## 摘要表

      | 调用方的位置           | `public` | `protected internal` | `protected` | `internal` | `private protected` | `private` |
      | ---------------------- | :------: | :------------------: | :---------: | :--------: | :-----------------: | :-------: |
      | 在类内                 |    ✔️️     |          ✔️           |      ✔️      |     ✔️      |          ✔️          |     ✔️     |
      | 派生类（相同程序集）   |    ✔️     |          ✔️           |      ✔️      |     ✔️      |          ✔️          |     ❌     |
      | 非派生类（相同程序集） |    ✔️     |          ✔️           |      ❌      |     ✔️      |          ❌          |     ❌     |
      | 派生类（不同程序集）   |    ✔️     |          ✔️           |      ✔️      |     ❌      |          ❌          |     ❌     |
      | 非派生类（不同程序集） |    ✔️     |          ❌           |      ❌      |     ❌      |          ❌          |     ❌     |

- 成员方法

  成员方法 （ 函数 ） 用来表现对象行为
  1 ． 申明在类语句块中
  2 ． 是用来描述对象的行为的
  3 ． 规则和函数申明规则相同
  4 ． 受到访问修饰符规则影响
  5 ． 返回值参数不做限制
  6 ． 方法数量不做限制

  > **注意** 成员方法不用加static关键字，必须实例化出对象，再通过对象来使用，相当于该对象执行了某个行为

- 构造函数和析构函数

  1.构造函数

  构造函数特点

  1.在实例化时会调用的用于初始化的函数

  2.如果不写会默认存在一个无参构造函数

  构造函数的写法

  1 ． 没有返回值

  2 ． 函数名和类名必须相同

  3 ． 没有特殊需求时一般都 是public 的

  ```c#
  class Person
  {
      string name;
      int age;
      public void Person()
      {
          name = "张三";
          age = 18;
      }
  	public void Person(string name,int _age) //重载
      {
          this.name = name;//this函数里面表示对象自己
          this.age = _age;
      }
  }
  ```

  > **注意：** 如果不自己实现无参构造函数，而实现了有参构造函数，会失去默认的无参构造

  构造函数的特殊写法

  ```c#
  class Person
  {
      string name;
      int age;
      public void Person()this("张三")//在无参构造函数时也可以添加常量进入含参构造函数
      {
          age = 18;
      }
      public void Person(string _name)
      {
          this.name = _name;
      }
  	public void Person(string _name,int _age) this(name)//this即该类的构造函数
      {
          this.age = _age;
      }
  }
  ```

  2.析构函数

  当引用类型的堆内存被**回收**时 ， 会调用该函数，对于需要手动管理内存的语言 （ 比如 c + + ） ，需要在析构函数中做一些内存回收处理。

  但是 c # 中存在自动垃圾回收机制 GC ， 所以我们几乎不会怎么使用析构函数 。 除非你想在某一个对象被垃圾回收时 ， 做一些特殊处理。

  > 注意：在Unity开发中析构函数几乎不会使用，所以该知识点只做了解即可。

  ```c#
  class Person
  {
      string name;
      int age;
      ~Person()// ~+类名即为析构函数，当引用类型的堆内存 被真正回收时 会调用该函数
      {
          name = "张三";
          age = 18;
      }
  }
  ```

  3.垃圾回收机制

  垃圾回收 ， 英文简写GC (Garbage collector)

  垃圾回收的过程是在遍历堆（Heap）上动态分配的所有对象

  通过识别它们是否被引用来确定哪些对象是垃圾 ， 哪些对象仍要被使用

  所渭的垃圾就是没有被任何变量 ， 对象引用的内容，垃圾就需要被回收释放

  垃圾回收有很多种算法 ， 比如

  引用计数 (Reference counting)

  标记清除 （ Mark sweep)

  标记整理 （ Mark compact)

  复制集合 （ copy collection)

  > 注意 ：
  >
  > GC 只负责堆 （ Heap ） 内存的垃圾回收
  >
  > 引用类型都是存在堆 （ Heap ） 中的 ， 所以它的分配和释放都通过垃圾回收机制来管理
  >
  > 栈 （ stack ） 上的内存是由系统自动管理的
  >
  > 值类型在栈 （ stack ） 中分配内存的 ， 他们有自己的申明周期 ， 不用对他们进行管理 ， 会自动分配和释放

  c # 中内存回收机制的大概原理

  0 代内存 1 代内存 2 代内存

  代的概念 ：

  代是垃圾回收机制使用的一种算法 （ 分代算法 ）

  新分配的对象都会被配置在第0代内存中

  每次分配都可能会进行垃圾回收以释放内存 （ 0代内存满时 ）

  > 在一次内存回收过程开始时 ， 垃圾回收器会认为堆中全是垃圾 ， 会进行以下两步
  >
  > 1 ． 标记对象从根 （ 静态字段 、 方法参数 ） 开始检查引用对象 ， 标记后为可达对象 ， 未标记为不可达对象
  >
  >  不可达对象就认为是垃圾
  >
  > 2 · 搬迁对象压缩堆 （ 挂起执行托管代码线程 ） 释放未标记的对象搬迁可达对象修改引用地址
  >
  > 大对象总被认为是第二代内存目的是减少性能损耗 ，提高性能，不会对大对象进行搬迁压缩 85000字节 (83kb) 以上的对象为大对象

  ```c#
  GC.collect()//主动去回收
  ```

  > 一般情况不会调用，在Loading条的时候使用。

- <span id="jump">成员属性</span>

  - 基本概念

    1.用于保护成员变量

    2.为成员属性的获取和赋值添加逻辑处理

    3.解决 3P 的局限性

    public一内外访问

    private— 内部访问

    protected— 内部和子类访问

    属性可以让成员变量在外部，只能获取不能修改或者只能修改不能获取

  - 示例

  ```c#
  class Person
  {
      private int age;
      public string Age //
      {
      	get
      	{
      		//加密处理
      		return age+5;
      	}
      	set
      	{
      		//加密处理
      		if(value<0)
      		{
      			value = 0;
      			Console.WriteLine("年龄不能小于0");
      		}
      		age = value-5;
      	}
      }
  }
  class main
  {
      Person p1 = new Person;
      Person p2 = new Person;
      p1.Age = 10; // 实际上为10
      p2.Age = -10;// 实际上为-10
  }
  ```

  > get和set可以加访问修饰符
  >
  > 注意
  > 1 ． 默认不加会使用属性申明时的访问权限
  >
  > 2 ． 加的访问修饰符要低于属性的访问权限
  >
  > 3 ． 不能让 get 和 set 的访问权限 **都低于** 属性的权限
  >
  > 3 ．  get 和 set 可以只有一个，此时不需要添加修饰符

  ```c#
  class Person
  {
      private int age;
      public string Age //
      {
      	get //默认public
      	{
      		//加密处理
      		return age+5;
      	}
      	private set //就只能在类里面设置该成员变量
      	{
      		//加密处理
      		if(value<0)
      		{
      			value = 0;
      			Console.WriteLine("年龄不能小于0");
      		}
      		age = value-5;
      	}
      }
  }
  ```

  - 自动属性

    作用 ： 外部能得不能改的特征,如果类中有一个特征是只希望外部能得不能改的又没什么特殊处理

    那么可以直接使用自动属性

  ```c#
    class Person
    {
        public int Height
        {
        	get;
        	private set;
        }
    }
  ```

  > 虽然成员属性可以替代成员变量，但会造成性能的消耗（代码变多了），只有[需要](#jump)的时候才引用。

- 索引器

  - 概念

    让对象可以像数组一样通过索引访问其中元素，使程序看起来更加直观，容易编写

  - 语法

   ```c#
    //访问修饰符 返回值 this[参数类型 参数名,参数类型,参数名]
    //{
    //	get
    //	{
    //		可以写逻辑
    //		return 返回值;
    //	};
    //	set
    //	{
    //		可以写逻辑
    //	};
    //}
     public class Person
     {
         private string name;
         private int age;
         private Person[] friends;
         public Person this[int index]
         {
             get
             {
                 if(index == 0 || index > friends.Length -1)
                 {
                     return null;
                 }
    			 else
                 {
                     return friends[index];
                 }
             }
             set
             {
                 if(friens == null)
                 {
                     friends = new People[]{value};
                 }
                 else if(index > friends.Length -1)
                 {
                     Person[friends.Length+1] newfriends = new Person;//新对象组长度加一
                     for(int i ;i<friends.Length;i++)//将旧的搬运过去
                     {
                         newfriends[i] = friends[i]; 
                     }
                     newfriends[friends.Length+1] = value;//添加新朋友
                     friends = newfriends;//转移引用到原来的friends
                 }else
                 {
                     friends[index] = value;//更改已有朋友
                 }
             }
         }
     }
   ```

    > 函数和属性的综合体，注意是[]中括号

    ```c#
    class main
    {
    	Person p = new Person;
        p[0] = new Person;//创建朋友0,让对象可以像数组一样通过索引访问其中元素
    }
    ```

  - 重载

   ```c#
     public class Person
     {
         private string name;
         private int age;
         private Person[] friends;
         private int[,] array;
         public int this[int i,int j]//索引器重载 this相当于变量名
         {
             get
             {
                 return array[i,j];
             }
             set
             {
                 array[i,j] = value;
             }
         }
         public Person this[int index]
         {
         //省略
         }
     }
   ```

    索引器主要作用可以让我们以中括号的形式，自定义类中的元素，规则自己定，访问时和数组一样,比较适用于 在类中有数组变量时使用，可以方便的访问和进行逻辑处理。

- 静态成员

  - 概念

    静态关键字 static，用 stat 让修饰的成员变量 、 方法 、 属性等称为静态成员

    直接使用类名点出来使用

    示例

    ```c#
    public class test
    {
    	private static float pi = 3.1415926f;
    }
    ```

  - 特点

    我们要使用的对象 ， 变量 ， 函数都是要在内存中分配内存空间的，之所以要实例化对象 ， 目的就是分配内存空间 ， 在程序中产生一个抽象的对象。
    
    程序开始运行时就会分配内存空间 。 所以我们就能直接使用 。
    
    静态成员和程序是一体的，只要使用了它 ， 直到程序结束时内存空间才会被释放，所以一个静态成员就会有自己唯一的一个 “ 内存小房间 ”，这让静态成员就有了唯一性。
    
    在任何地方使用都是用的小房间里的内容 ， 改变了它也是改变小房间里的内容 。
    
    > 注意：静态函数中不能使用非静态成员,成员变量只能将对象实例化出来后才能点出来使用不能直接使用非静态成语，否则会报错。
    >
    > ​			非静态函数可以使用静态成员
    
    静态变量常用唯一的变量，方便别人获取的对象声明，静态方法常用来唯一的方法声明。
    
  - const常量可以看做特殊的static

    相同点
    	他们都可以通过类名点出使用
    不同点

    1 .   const 必须初始化 ， 不能修改，static 没有这个规则

    2  .  const 只能修饰变量 、 static可以修饰很多

    3  .  const 一定是写在访问修饰符后面的 ， static没有这个要求

- 静态类和静态构造函数

  - 静态类

    用 static 修饰的类

    特点

    1 .  **只能包含静态成员**

    2 . **不能被实例化**

    作用

    1 ． 将常用的静态成员写在静态类中方便使用

    2 ． 静态类不能被实例化 ， 更能体现工具类的唯删国

  - 静态构造函数

    在构造函数上加上static修饰

    特点

    1 .  静态类和普通类都可以有

    2 .  不能使用访问修饰符

    3 .  不能有参数

    4 .  只会自动调用一次

    作用

    在静态构造函数中初始化静态变量

    ```c#
    class Test
    {
    	static Test()
    	{
    		Console.WriteLine("静态构造函数")
    	}
    	public Test()
    	{
    		Console.WriteLine("普通构造函数")
    	}
    }
    class Program
    {
        Static void main()
        {
        Test t = new Test();
        Test t2 = new Test(); 
        }
    }
    /*输出
    静态构造函数
    普通构造函数
    普通构造函数
    */
    ```

    

- 拓展方法

  **为现有 <u>非静态</u> 变量类型添加新方法**

  作用

  1 .  提升程序拓展性
  2 .  不需要再对象中重新写方法
  3 .  不需要继承来添加方法
  4 .  为别人封装的类型写额外的方法

  特点
  1 .  一定是写在静态类中
  2 .  一定是个静态函数
  3 .  第一个参数为拓展目标
  4 .  第一个参数用 this 修饰
  
  ```c#
  //访问修饰符 static 返回值 函数名(this 拓展类名 参数名,参数类型 参数名,......)
  //成员方法 是需要 实例化对象后 才能使用的
  //value 代表 使用该方法的 实例化对象
  static class tool
  {
      public static void SpeakValue(this int value)//here 第一个参数是规则，规定了为谁拓展的方法
      {
          Console.WriteLine("为Int拓展的方法"+value);
      }
  }
  class Program
  {
      static void Main(string[] Args)
      {
          Console.WriteLine("拓展方法");
          int i = 2;
          i.SpeakValue();
      }
  }
  //输出
  //拓展方法
  //为Int拓展的方法2
  ```
  
  >  注意：如果拓展的方法和原有的方法重名且参数相同，那么调用原有的方法
  
- 运算符重载

  概念

  让自定义类和结构体，能够使用运算符，使用关键字operator

  特点

  1 .  一定是一个公共的静态方法

  2 .  返回值写在operator前

  3 .  逻辑处理自定义

  作用

  1 .  让自定义类和结构体对象可以进行运算

  注意

  1 .  条件运算符需要成对实现

  2 .  一个符号可以多个重载

  3 .  不能使用 ref 和 out

  基本语法

  ```c#
  //public static 返回类型 operator 运算符(参数列表)
  class Point
  {
  	public int x;
  	public int y;
  	public static Point operator +(Point p1,Point p2)
  	{
  		Point p = new Point();
  		p.x = p1.x + p2.x;
  		p.y = p1.y + p2.y;
  		return p;
  	}
      public static Point operator +(Point p1,int value)
  	{
  		Point p = new Point();
  		p.x = p1.x + value;
  		p.y = p1.y + value;
  		return p;
  	}
  }
  class Program
  {
      static void Main(String[] Args)
      {
          Point p1 = new Point();
          Point p2 = new Point();
          p1.x = 3;
          p1.y = 4;
          p2.x = 5;
          p2.y = 6;
          Point p3 = p1 + p2;
          Point p4 = p2 + 3;//正确，重载参数中必须有一个为返回值的类型。
          Point p5 = 3 + p4;//错误，重载和参数顺序有关
      }
  }
  ```

  可重载的运算符：算数运算符（都可以），逻辑运算符（只有非!），位运算符（都可以），条件运算符（都可以，但是必须成对实现）

  不可重载的运算符：逻辑与&&，逻辑或||，索引符[]，强势运算符()，特殊运算符（点. 三目运算符?:赋值符号=）

- 内部类和分部类

  内部类

  概念

  ​	在一个类中，再声明一个类

  特点

  ​	在使用时要用包裹者点出自己

  作用

  ​	亲密关系的表现

  注意

  ​	访问修饰符作用很大

  ```c#
  calss Person
  {
  	public int age;
  	public string name;
  	public Body body;
  	public class Body
      {
          Arm leftArm;
          Arm rightArm;
          class Arm;
      }
  }
  class Program
  {
      static void Main(string[] Args)
      {
  		Person p = new Person();
          Person p.Body b = new Person.Body();
          Person p.Body.Arm a = new Person.Body.Arm();//错误，访问权限不足
      }
  }
  ```

  分部类

  概念

  ​	把一个类分成几部分，关键字 `partial`

  作用

  ​	分布描述一个类

  ​	增加程序拓展性

  注意

  ​	分布类可以写在多脚本文件中

  ​	分布类的访问修饰符要一致

  ​	分布类中不能有重复成员

  ```c#
  partial class Student
  {
  	public name;
      public num;
  }
  partial class Student
  {
  	public sex;
      public void Speak();
  }
  ```

  分部方法

  概念

  ​	将方法的声明和实现分离，用分部关键字去声明的方法

  特点

  1 .  不能加访问修饰符默认私有

  2 .  只能在分部类中申明

  3 .  返回值只能是void

  4 .  可以有参数，但不能用out关键字

  ```c#
  partial class Student
  {
  	public name;
      public num;
      partial void Speak();
  }
  partial class Student
  {
  	public sex;
      partial void Speak()
      {
          //实现逻辑
      }
  }
  ```

  

### 3. 面对对象-继承

- 复用封装对象的代码

- 继承的基本原则

- 里式替换原则

- 继承中的构造函数

- 万物之父和装箱拆箱

- 密封类

### 4.面对对象-多态

同样行为的不同表现

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

---

参考文献

 [ 微软 | Microft docs.访问修饰符(C# 编程指南)](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/public) 

