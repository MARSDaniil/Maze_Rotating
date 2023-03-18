using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField]  GameObject Field;

    [SerializeField]  float speedOfRotation = 15;


    [SerializeField] float timeOfWait = 5f;
    // Update is called once per frame
    private bool canRotate = false;

    private void Start()
    {
        //        StartCoroutine(WaitAndTurnOn());
        canRotate = true;
    }

    private IEnumerator WaitAndTurnOn()
    {     
        yield return new WaitForSeconds(timeOfWait);
        canRotate = true;
    }

    void FixedUpdate()
    {
        
            if (Input.GetAxis("Horizontal") != 0 && canRotate == true)
            {
                Rotate(Input.GetAxis("Horizontal"));
            }

    }

    void Rotate(float ditectionOfRotate)//rotate plate
    {
        Field.transform.Rotate(0, 0, -ditectionOfRotate * speedOfRotation * Time.fixedDeltaTime);
    }
}
