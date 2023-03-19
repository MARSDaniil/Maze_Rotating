using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField]  GameObject Field;

    [SerializeField]  float speedOfRotation = 15;


    // Update is called once per frame
    

    private void Start()
    {
#if UNITY_IOS || UNITY_ANDROID
        Input.gyro.enabled = true;
#endif

    }



    void FixedUpdate()
    {

#if UNITY_STANDALONE || UNITY_WEBGL
        if (Input.GetAxis("Horizontal") != 0)
        {
            Rotate(Input.GetAxis("Horizontal"));
        }
#endif
       
#if UNITY_IOS || UNITY_ANDROID
        /*
         if (Input.gyro.attitude.eulerAngles.x != 0)
         {
             Debug.Log(Input.gyro.attitude);
             Rotate(Input.gyro.attitude.eulerAngles.z);
         }
        */
        Debug.Log(Input.gyro.attitude);
#endif
    }

    void Rotate(float ditectionOfRotate)//rotate plate
    {
        Field.transform.Rotate(0, 0, -ditectionOfRotate * speedOfRotation * Time.fixedDeltaTime);
    }
}
