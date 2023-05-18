# Unity Make It Flow中文指南

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-18_22-45-26.png)

# MakeItFlow可以干什么

Make It Flow是一个设置你的对象将如何表现，将其链接到用户操作的编辑器工具和UGUI触发器框架

通俗的讲，可以像PPT一样直接点击编辑  **图片**  的动画效果

注意：作用对象是图片！（可以包含其他子物体）

# MakeItFlow怎么用

## 一、包管理器中导入包

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-18_22-57-13.png)

## 二、必要准备

打开 工具 **tool**  ->  **Make It Flow**，将此窗口（以下简称MF窗口）拖到想要的位置

在层级 **Hierarchy** 中，右键创建UI -> 画布 **Canvas** ，选中Canvas，MF窗口中会出现Set up MF enviroment，点击创建MF环境

> 此时一般会在层级**Hierarchy** 中自动创建MF System Manager，如果没有，那么在Assets\Make It Flow\Prefabs目录下，有一个预制体MF System Manager，可以自己创建

至此，相关准备已经做好

## 三、开始创建

在Canvas下创建UI -> 图像Image，选中Image，MF窗口会出现Make this an MF object，点击创建MF对象 

在MF窗口中，点击Add Behavior添加动作

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-18_23-51-28.png)

具体动画（动作）有：

| 名称                     | 动画效果                                     |
| ------------------------ | :------------------------------------------- |
| Alpha Curve              | 调整透明度曲线                               |
| Angle Curve              | 翻转（X,Y,Z）曲线                            |
| Call Method              | 运行自定义方法                               |
| Change Sprite            | 改变图片                                     |
| Color Gradient           | 渐变                                         |
| Delay                    | 等待                                         |
| Follow Angle To Target   | 跟随目标旋转                                 |
| Follow Pointer           | 跟随指针（拖拽效果）                         |
| Follow Pointer Spring    | 弹簧式跟随指针（拖拽效果），即拖拽时产生惯性 |
| Follow Target position   | 跟随目标transform位置                        |
| Look At Pointer Position | 面向指针位置                                 |
| Outline                  | 添加外轮廓                                   |
| Position Curve           | 改变位置曲线                                 |
| Rect Size Curve          | 改变尺寸曲线                                 |
| Rotate                   | 旋转                                         |
| Scale                    | 改变大小                                     |
| Scale Curve              | 改变大小曲线                                 |
| Set Parent               | 设置父物体                                   |
| Translate To Target      | 跟随目标transform位置曲线                    |

创建好后可以选择触发动画的方式

有Triggers（触发器）,Parallel MF objects（平行MF对象）,Sequence Behaviors（序列动作）,Complementary Behaviors（互补动作）四种触发方式。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-19_00-11-31.png)

### 1.Triggers（触发器）



![image-20230519001743484](C:\Users\13038\AppData\Roaming\Typora\typora-user-images\image-20230519001743484.png)



逻辑为When [object event group] [object event] On [MF object] Then [behavior call]

也就是当【对象事件组】的【对象事件】被触发时，【MF对象】就【动作】

对象事件组：中包含了鼠标点击，拖拽，指针悬停，被选择，系统事件，自定义事件。

对象事件：基于对象事件组的事件，比如鼠标左键按下，鼠标左键抬起等。

MF对象：调用事件的对象。可以选择任何MF对象作为目标，也可以设置为none。

- 选择MF对象作为触发器将使此事件仅在被选择对象上执行时才被调用 
- 如果该字段被清除，没有被选择，则该事件将被调用，因为该事件没有任何发生条件
- 即使指针下没有对象，也会调用可点击、可拖动和系统事件 
- 如果指针下有对象，悬停和可选择事件将被调用。

动作：你以从三种类型的动作调用中选择，在触发发生时调用，启动或停止:
- StartBehavior:启动动作。 
- StopOnBehaviorEnd:在一次调用中完全执行的不同then动作，一些动作将在设定的时间内进行平滑过渡，对于那些动作，此调用将标记该动作在该动作完全完成时停止。例如:如果这个调用是对颜色渐变动作进行的，对象将完成过渡到结束颜色然后停止。 
- InterruptBehavior:这个调用立即中断动作。

大多数动作，一旦开始，就不能再次开始，直到完成或中断。

触发器列表，以逻辑句子的形式，表明此动作将进行哪些事件。这是配置一个动作的主要部分，你可以用触发器来让此对象开始、停止(当动作结束时)或中断(一旦触发被调用)这个动作。

### 2.Parallel MF objects（平行MF对象）

在已添加动作的MF对象中添加Parallel MF objects新对象，会使MF原对象在执行动作时，新对象一起执行相同动作。

![image-20230519002733309](C:\Users\13038\AppData\Roaming\Typora\typora-user-images\image-20230519002733309.png)

### 3.Sequence Behaviors（序列动作）

可以在具体某一对象的某一动作的开始（结束，打断）时，此对象开始执行操作

![image-20230519003152451](C:\Users\13038\AppData\Roaming\Typora\typora-user-images\image-20230519003152451.png)

### 4.Complementary Behaviors（互补动作）

当且仅当一个MF物体只有AB两个动作时,已经在A中设置了触发器的启动和打断两种条件，那么动作A中输入互补动作B,就会在动作B中自动补全触发条件，比如实现指针悬停在图片时放大图片，离开图片时缩小图片

A:

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-19_00-38-27.png)

B:

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-19_00-38-50.png)

不同的动作可以相互结合，大大节约了开发者对UI开发的时间成本

**以上就是Make It Flow的基础操作，感谢大家的观看！**o(￣ε￣*) 