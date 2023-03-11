using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldBall : MonoBehaviour
{
    //[SerializeField] GameObject Sphere;
    public Rigidbody rb;
   
    // Start is called before the first frame update
    private float borderRight = -0.6f;
    private float borderLeft = -0.4f;
    private float borderNormal = -0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0.2f, 0.5f, -0.5f);
        StartCoroutine(WaitAndTurnOn(rb));
    }

    void Update()
    {
        if (transform.position.z < borderRight || transform.position.z > borderLeft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.x, borderNormal);
        }
    }

   private IEnumerator WaitAndTurnOn(Rigidbody rb)
    {
        rb.isKinematic = true;
        //Debug.Log("u ender to coroinin");
        new WaitForSeconds(1f);
        rb.isKinematic = false;
        yield return null ;
    }
}
