using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    [SerializeField] Camera Camera;

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y, -30f);
    }
}
