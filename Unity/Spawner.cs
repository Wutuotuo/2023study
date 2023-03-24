using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int direction;
    //创建列表来存储物品
    public List<GameObject> SpawnerObjects;
    private void Spawn()
    {
        var index =  Random.Range(0,SpawnerObjects.Count);
        var target = Instantiate(SpawnerObjects[index],transform.position,Quaternion.identity,transform);
        target.GetComponent<MoveForward>().dir = direction;
    }
    private void Start()
    {
        InvokeRepeating(nameof(Spawn),0.2f,Random.Range(7.5f,9f));
    }
}
