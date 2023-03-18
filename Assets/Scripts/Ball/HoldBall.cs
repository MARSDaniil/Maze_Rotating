using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldBall : MonoBehaviour
{
    [SerializeField] float timeOfWait = 1f;
    public Rigidbody rb;

    public bool canRotate = false;
 //   [SerializeField] bool isOpen = true;
   
    // Start is called before the first frame update
    private float borderRight = -0.6f;
    private float borderLeft = -0.4f;
    private float borderNormal = -0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0.2f, 0.5f, -0.5f);   
       // StartCoroutine(WaitAndTurnOn());

       
    }

    void Update()
    {
        if (transform.position.z < borderRight || transform.position.z > borderLeft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.x, borderNormal);
        }
    }

   private IEnumerator WaitAndTurnOn()
    {
        rb.isKinematic = true;
      //  Debug.Log("state of rb.isKinematic ==" + rb.isKinematic);
        yield return new WaitForSeconds(timeOfWait);
        rb.isKinematic = false;
        //  Debug.Log("state of rb.isKinematic ==" + rb.isKinematic);
        canRotate = true;
    }
}
