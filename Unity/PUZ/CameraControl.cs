using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform frog;
    public float offsetY;
    private float ratio;
    public float zoombase;
    //不同的摄像机看到的画面应该相同
    private void Start() 
    {
    //强制转换FLOAT否则会有问题
        ratio = (float)Screen.height / (float)Screen.width;
        //Debug.Log(ratio);
        Camera.main.orthographicSize = zoombase * ratio * 0.5f;
    }
    //摄像机以青蛙为基准跟随移动
    public  void LateUpdate() 
    {
        transform.position = new Vector3(transform.position.x,frog.transform.position.y+offsetY*ratio,transform.position.z);
    }
}
