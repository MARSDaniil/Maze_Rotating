using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    [SerializeField] private GameObject Field;

    private bool clockwiseRotation = false;
    private bool counterclockwiseRotation = false;
    [SerializeField] private float speedOfRotation = 5;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            RotateDown("D");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            RotateUp("D");
        }
        if(clockwiseRotation == true)
        {
            Rotate(-1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateDown("A");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            RotateUp("A");
        }
        if (counterclockwiseRotation == true)
        {
            Rotate(1);
        }

    }

    void RotateDown(string nameOfBottom)//is bottom pushed
    {
        if (nameOfBottom == "D")
        {
            clockwiseRotation = true;
            counterclockwiseRotation = false;
        } 
        if (nameOfBottom == "A")
        {
            counterclockwiseRotation = true;
            clockwiseRotation = false;
        }
    }

    void RotateUp(string nameOfBottom) //is bottom unpushed
    {
        clockwiseRotation = false;
        counterclockwiseRotation = false;
    }
    void Rotate(sbyte ditectionOfRotate)//rotate plate
    {
        Field.transform.Rotate(0, 0, ditectionOfRotate * speedOfRotation * Time.deltaTime);
    }
}
