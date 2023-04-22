using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyMoveCamera : MonoBehaviour
{
    public Camera Camera;


    public GameObject Ball;


    // Update is called once per frame
    void Start()
    {
        /*
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();
        

        Camera.transform.position = new Vector3(0, 0, -mazeSpawner.sizeOfMaze * rangeFactor-5);
        */
       
       
        Camera.orthographicSize = 2;
    }

    void Update()
    {
        Camera.transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y, transform.position.z);
        
    }
}