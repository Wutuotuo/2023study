using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Checkposition();
    }
    private void Checkposition()
    {
        if(Camera.main.transform.position.y - transform.position.y>35)
        {
            Destroy(this.gameObject);
        }
    }
}
