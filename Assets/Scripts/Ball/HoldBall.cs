using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldBall : MonoBehaviour
{
    [SerializeField] GameObject Sphere;
   
    // Start is called before the first frame update
    private float borderRight = -0.6f;
    private float borderLeft = -0.4f;
    private float borderNormal = -0.5f;
    void Start()
    {
        transform.position = new Vector3(0.2f, 0.5f, -0.5f);
        Cell ball = Instantiate(Sphere, new Vector3(0,0,0),Quaternion.identity).GetComponent<Cell>();
        ball.transform.parent = gameObject.transform;
       
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
