using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField]  GameObject Field;

    [SerializeField]  float speedOfRotation = 15;

    [SerializeField] GameObject Ball;

    [SerializeField] GameOver gameOver;

    private float screenWidth;
    // Update is called once per frame

    private bool firstTouch = false;

    [SerializeField]
    float timeOfWait;
    private void Start()
    {
        Ball = GameObject.Find("Sphere");
        gameOver = Ball.GetComponent<GameOver>();

        StartCoroutine(Co_WaitForSeconds(timeOfWait));


#if UNITY_STANDALONE || UNITY_WEBGL

        if (Application.isMobilePlatform == true)
        {
            Debug.Log("Mobile");
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
        /*
        if(firstTouch == false)
        {
            float speed = speedOfRotation;
            speedOfRotation = 0;
            StartCoroutine(Co_WaitForSeconds(0.1f));
            firstTouch = true;
            speedOfRotation = speed;
        }
        */
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
        if (gameOver.isWin == false)
        {
            Field.transform.Rotate(0, 0, -ditectionOfRotate * speedOfRotation * Time.fixedDeltaTime);
        }
    }

    private void isTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 position = touch.position;
            if (position.x > screenWidth / 2)
            {
                Rotate(1);
            }
            if (position.x < screenWidth / 2)
            {
                Rotate(-1);

            }
  //          Debug.Log("touch position - " + position);
        }
    }


    private IEnumerator Co_WaitForSeconds(float value)
    {
        float speed = speedOfRotation;
        speedOfRotation = 0; 
        Debug.Log("Start of waiting");
        // Do something before
        yield return new WaitForSeconds(value);
        // Do something after
        speedOfRotation = speed;
        Debug.Log("Finish of wauting");
        firstTouch = true;
    }
}
