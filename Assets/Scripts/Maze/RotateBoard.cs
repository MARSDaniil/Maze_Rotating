using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField] private GameObject Field;

    [SerializeField] private float speedOfRotation = 15;
    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetAxis("Horizontal") != 0)
        {
            Rotate(Input.GetAxis("Horizontal"));
        }
    }

    void Rotate(float ditectionOfRotate)//rotate plate
    {
        Field.transform.Rotate(0, 0, -ditectionOfRotate * speedOfRotation * Time.deltaTime);
    }
}
