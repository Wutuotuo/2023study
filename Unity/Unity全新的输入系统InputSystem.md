#全新的输入系统InputSystem

## 一、旧的输入管理器

在Unity中，默认使用的是旧的输入管理器（InputSystemOld）

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_20-57-49.png)


在脚本中，利用Input类可以获得用户的输入操作，以及访问移动设备的多点触控或加速感应数据，Input类可以读取输入管理器中设置的按键，在Updata函数中监测用户的输入。

### 1.虚拟轴

在项目设置中可以看到虚拟轴的相关设置

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_21-00-59.png)

例如在输入管理器中，可以看到对应的按键

以Horzizontal举例，监测的是键盘的AD以及左右箭头

float value=Input.GetAxis ("Horzizontal");使用平滑滤波器的虚拟轴值。不按是0，正向为1，负向为-1，按下去会由0逐渐的过渡到1或-1，变化过程由灵敏度决定

float value=Input.GetAxisRaw ("Horzizontal");//不使用平滑滤波器的虚拟轴值。 （取值1，0，-1）

比如使用AD控制人物角色的左右移动

```c#
private CharacterController characterController;//使用CharacterController组件控制物体
private void Start()
{
    characterController = GetComponent<CharacterController>();//得到自身的CharacterController组件
}
private void Update() 
{
    float tmp_CurrentSpeed = 1.7f;//速度
    float tmp_Horizontal = Input.GetAxis("Horizontal");//按下AD返回一个1~-1随时间过渡的float值
    Vector3 movementDirection = characterTransform.TransformDirection(new Vector3(tmp_Horizontal,0,0));//移动的方向，参数为x,z,y
    characterController.Move(tmp_CurrentSpeed * Time.deltaTime * movementDirection);//控制物体移动
}
```

### 2.获取键盘输入

Jump监测键盘的空格

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_21-38-16.png)

bool result=Input. GetButton("Jump");   //监测是否输入对应按键

bool result=Input. GetButtonDown("Jump");  //监测是否完全按下对应按键

bool result=Input. GetButtonUp("Jump");////监测是否松开对应按键

比如控制人物角色的跳跃

```c#
private CharacterController characterController;//使用CharacterController组件控制物体
private void Start()
{
    characterController = GetComponent<CharacterController>();//得到自身的CharacterController组件
}
private void Update() 
{
    float tmp_CurrentSpeed = 1.7f;//速度
    float tmp_JumpHeight = 3.0f;//跳跃高度
    float tmp_Horizontal = Input.GetAxis("Horizontal");//按下AD返回一个1~-1随时间过渡的float值
    Vector3 movementDirection = characterTransform.TransformDirection(new Vector3(tmp_Horizontal,0,0));//移动的方向，参数为x,z,y
    if(Input.GetButtonDown("Jump"))//当按下空格后
    {
        movementDirection.y = tmp_JumpHeight;
    }
    characterController.Move(tmp_CurrentSpeed * Time.deltaTime * movementDirection);//控制物体移动
}
```

### 3.获取鼠标输入

bool result=Input.GetMouseButton(0);//当鼠标按住左键时

bool result=Input.GetMouseButtonDown(1);//当鼠标按下右键时

bool result=Input.GetMouseButtonUp(2);//当鼠标抬起中键时

## 二、新的输入系统包

### 1.使用前

> **注意** ：新的输入系统需要 Unity 2019.4+ 和 .NET 4 运行时。它不适用于使用旧 .NET 3.5 运行时的项目。

要安装新的输入系统，请打开 Unity 的包管理器（菜单： **窗口>包管理器** ）。从列表中选择 **输入系统** 软件包，然后单击 **安装** 。 

默认情况下，Unity 的经典输入管理器 （ `UnityEngine.Input`） 处于活动状态，对新输入系统的支持处于非活动状态。

这允许现有的 Unity 项目保持原样工作。 安装输入系统包时，Unity 将询问您是否要启用新的后端。如果单击 **“是** ”，Unity 将启用新后端并禁用旧后端，编辑器将重新启动。 

### 2.使用时

对控制对象添加控件PlayerInput

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_22-05-54.png)

创建输入操作，右键->创建->InputAction，将其链接到PlayerInput组件的Action中，可以根据项目的需求设置按键

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_22-05-13.png)

设置操作响应，一旦组件有了它的Actions，您就必须为每个Action设置一个响应。PlayerInput允许你以几种方式设置响应，使用检视Inspector窗口中的Behavior属性。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-16_22-22-33.png)

上面的截图使用了Invoke Unity Events，它以与Unity UI相同的方式使用了UnityEvent。Unity为每个链接到组件的Action显示一个事件。这允许您直接为每个事件连接目标方法。上图为Action中的Jump,LongJump,TouchPosition行为，分别连接了PlayerController脚本中public修饰的Jump,LongJump,Gettouchposition方法。

> 注意，在方法脚本中，需要使用命名空间using UnityEngine.InputSystem;同时获取PlayerInput控件。

---

学习过程中参考了以下内容，诚挚感谢知识的分享者！

[2022 Unity 技术 |Unity官方手册](https://docs.unity.cn/Packages/com.unity.inputsystem@1.3/manual/index.html)