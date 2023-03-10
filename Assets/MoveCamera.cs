using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    [SerializeField] Camera camera;

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y, -30f);
    }
}
