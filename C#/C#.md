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

## 实例

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

### 12.条件分支语句

### 13.循环语句

## 二、实践项目

### 1.控制台相关方法

### 2.随机数

### 3.项目测试

### 4.实践

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