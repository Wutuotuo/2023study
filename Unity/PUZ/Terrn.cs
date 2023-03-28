using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrn : MonoBehaviour
{
    private int lastnum = 4;
    public float offsety;
    private GameObject spanobject;//生成的物品
   
    public List<GameObject> SpawnerObjects; //创建列表来存储物品
    private void Spawn()
    {
        
        var index =  Random.Range(0,SpawnerObjects.Count);//生成一个随机数字0到序号
        
        while (lastnum == index)
        {
            index =  Random.Range(0,SpawnerObjects.Count);//生成一个随机数字0到序号
        }
        lastnum = index;
        spanobject = SpawnerObjects[index];
        Instantiate(spanobject,transform.position, Quaternion.identity);
    }
    
    public void Checkposition()
    {
        if(transform.position.y - Camera.main.transform.position.y < offsety / 2 )
        {
            transform.position = new Vector3(0,Camera.main.transform.position.y+offsety,0);
            Spawn();
        }
    }
        //注册
    private void OnEnable()
    {
        //使用+=来注册
        EventHandler.GetPointEvent+= OnGetPointEvent;//注册函数的参数必须和方法相同
    }
     //注销
    private void OnDisable()
    {
        //使用-=来注销
        EventHandler.GetPointEvent-= OnGetPointEvent;//注销函数的参数必须和方法相同
    }

    private void OnGetPointEvent(int obj)
    {
        Checkposition();
    }

    // private void Start() 
    // {
    //     Checkposition(); 
    // }
}
