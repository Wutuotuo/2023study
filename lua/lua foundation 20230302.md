# lua语言基础 **2023/03/02**

官网[www.lua.org](www.lua.org)
- 动态脚本语言用于实现逻辑
- 多平台编译

### 1.变量

1.默认声明全局变量
2.没有声明的变量为nil(NULL)

### 2.数值型

1.支持16进制与科学计数法，同时所数值类型均为number

### 3.运算符

1.支持符号运算 例如^(幂运算),<<(位运算)
### 4.字符串
1.单引号双引号均可
2.支持转义字符
3.字符串的连接符号为..而非+
4.支持类型转换
### 5.函数
1.函数体

```lua
funtion function_name(...)

--body

end
```

或者

```lua
funtion_name = function(...)

--body

end
```

### 6.数组

1.可以存放多种类型

```
a = {1,"a",{},function() end}			//数值，字符串，数组，函数
```

2.开始值为1

```lua
print(a[1])

输出 1
```

3.可以使用#获取数组长度

```lua
print(#a)

输出 5
```

4.支持insert,remove

```lua
table.insert(a,"d")

print (a[6])

输出 d
```

```lua
table.insert(a,2,"c")

print (a[2])

输出 c
```

remove会将移除的元素返回

```
local s  = table.remove( a,2 )

print (a[2])

输出 a
```

5.用字符串作为数组下标

```lua
a = {

​		a = 1,

​		b = "1234",

​		c = function()

​		end,

​		d = {}

}

print (a["b"]) 或者print (a.a)

输出 1234
```

6.所有的全局变量都在_G里面

```lau
a= 1

print(_G["a"])

输出 1
```

### 7.真假

1.支持布尔值

```lua
--lua中，0也为真
a = true
b = false
print(a>b)
print(a<b)
print(a>=b)
print(a<=b)
print(a==b)
--不是!=
print(a~=b) 
print(a and b) 
print(a or b)
--lua中 and 和 or 也会返回值，可以用来短路求值

a = 0
print (a >10 and "yes" or "no")
输出 no

print(a not b) 
```

### 8.判断
1.用then和end设置代码块

```lua
if 1>10 then
	print("1>10")
else 或者elseif()
    print("1~=10")
end
```

### 9.循环
1.for循环，while循环, repeat循环

```lua
for i = 1, 3 do
	print(i)
end
输出 1 2 3
for i = 1, 10 , 2 do
    print (i)
end
输出 1 3 5 7 9
--在for循环里面不允许修改循环循环变量

local n = 3
while n > 1 do
    print (n)
    n = n - 1
end
输出 3 2
--lua不允许使用++，--操作
```

2.可以使用break跳出循环
### 10.补充
1.lua里string字符串与c字符数组比较相近,但是C语言中0代表结束，而lua允许存放0x00

```lua
s = string.char(0x30,0x31,0x32,0x33,0x00)
n = string.byte(s,5)
print(s)
print(n)
--0对应0x00
输出 0123?
	0
```

2.参考手册

[lua各版本参考手册](http://www.lua.org/manual/)

