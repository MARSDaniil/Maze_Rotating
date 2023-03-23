using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField]  GameObject Field;

    [SerializeField]  float speedOfRotation = 15;

    private float screenHeight;
    private float screenWidth;
    // Update is called once per frame


    private void Start()
    {
#if UNITY_STANDALONE || UNITY_WEBGL

        if (Application.isMobilePlatform == true)
        {
            screenWidth = Screen.width;
        }
#endif
#if UNITY_IOS || UNITY_ANDROID
        screenWidth = Screen.width;
        Debug.Log("Screen Height : " + Screen.height);
        Debug.Log("Screen Width : " + Screen.width);
#endif

    }



    void FixedUpdate()
    {

#if UNITY_STANDALONE || UNITY_WEBGL

        if (Application.isMobilePlatform == true)
        {
            isTouch();
        }
        else if (Input.GetAxis("Horizontal") != 0)
        {
            Rotate(Input.GetAxis("Horizontal"));
        }
#endif

#if UNITY_IOS || UNITY_ANDROID
   
        isTouch();

          
#endif
    }

    void Rotate(float ditectionOfRotate)//rotate plate
    {
        Field.transform.Rotate(0, 0, -ditectionOfRotate * speedOfRotation * Time.fixedDeltaTime);
    }

    private void isTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 position = touch.position;
            if (position.x > screenWidth / 2)
            {
                Rotate(-1);
            }
            if (position.x < screenWidth / 2)
            {
                Rotate(1);

            }
            Debug.Log("touch position - " + position);
        }
    }
}
