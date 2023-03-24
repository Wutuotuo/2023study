using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//不用挂载到任何物体上，就不会有任何父类函数
public class EventHandler
{
    //每次跳跃控制得分和摄像机
    public static event Action<int> GetPointEvent;//去定义通知其它函数和类要调用的数值类型
    public static void CallGetPointEvent(int point)//来具体呼叫的函数
    {
        //  if(GetPointEvent != null)
        //  {
        //     //启动这个
        //     GetPointEvent.Invoke(point);
        //  }
        //问号等同于 不为空的情况下再执行
        GetPointEvent?.Invoke(point);
    }
    //游戏结束控制UI
    public static event Action GameOverEvent;
    public static void CallGameOverEvent()
    {
        GameOverEvent?.Invoke();
    }
}
