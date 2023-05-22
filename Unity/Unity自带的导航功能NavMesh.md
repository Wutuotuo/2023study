Unity自带的导航功能NavMesh

# 一、功能

导航系统允许使用从场景几何体自动创建的导航网格来创建可在游戏世界中智能移动的角色。动态障碍物可让您在运行时更改角色的导航，而网格外链接 (Off-Mesh Link) 可让您构建特定动作，如打开门或从窗台跳下。

# 二、构建

## 1.可行走区域

导航系统需要自己的数据来表示游戏场景中的可行走区域。可行走区域定义了代理可在场景中站立和移动的位置。在 Unity  中，代理被描述为圆柱体。可行走区域是通过测试代理可站立的位置从场景中的几何体自动构建的。然后，这些位置连接到场景几何体之上覆盖的表面。该表面称为导航网格（简称 NavMesh）。

导航网格将该表面存储为凸多边形。凸多边形是一种有用的表示，因为我们知道多边形内的任意两点之间没有障碍物。除了多边形边界之外，我们还存储有关哪些多边形彼此相邻的信息。这使我们能够推断整个可行走区域。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-22_14-53-29.png)

地面是可行走的，选中所有地面，点击窗口(Window)->AI->导航(Navigation)，勾选Navigation，在烘焙(Bake)中点击Bake。

对于不可行走的岩石，可以在勾选Navigation时，选择下方的NotWalkable，然后进行烘焙。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-22_14-56-16.png)

## 2. 移动代理

最后在转向和障碍躲避之后计算最终速度。在 Unity 中使用简单的动态模型来模拟代理，该模型还考虑了加速度以实现更自然和平滑的移动。

在此阶段，您可以将速度从模拟的代理提供给动画系统，从而使用根运动移动角色，或让导航系统处理该问题。

使用任一方法移动代理后，模拟代理位置将移动并约束到导航网格。最后这一小步对于实现强大的导航功能非常重要。

对怪物添加Nav Mesh Agent组件，设置好对应参数。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-22_15-02-43.png)

然后编写一个脚本挂载到怪物身上。

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentFollow : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;//导航代理组件
    public Transform tragetTransform;//目标位置
    void Update()
    {
        navMeshAgent.SetDestination(tragetTransform.position);
    }
}
```

怪物就会按照可以行走的区域追逐目标单位。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-22_15-06-49.png)

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-22_15-06-54.png)