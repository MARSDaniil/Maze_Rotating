using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldBall : MonoBehaviour
{
   
    // Start is called before the first frame update
    private float borderRight = -1.1f;
    private float borderLeft = -0.9f;
    private float borderNormal = -1f;
    void Start()
    {
       transform.position = new Vector3(0f, 0.5f, -1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < borderRight || transform.position.z > borderLeft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.x, borderNormal);
        }
    }
}
