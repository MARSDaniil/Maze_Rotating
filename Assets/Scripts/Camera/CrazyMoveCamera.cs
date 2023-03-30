using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyMoveCamera : MonoBehaviour
{
    public Camera Camera;
    public GameObject Board;
    public GameObject Ball;
    public float rangeFactor = 1;
    // Update is called once per frame
    void Start()
    {
        /*
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();
        

        Camera.transform.position = new Vector3(0, 0, -mazeSpawner.sizeOfMaze * rangeFactor-5);
        */
        Ball = GameObject.Find("Sphere");


        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();

        Camera.orthographicSize = Mathf.Sqrt(Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2) + Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2)) + 1;
    }

    void Update()
    {
        Camera.transform.position = new Vector3(Ball.transform.position.x, Ball.transform.position.y, -15f);
        Camera.transform.Rotate(Ball.transform.rotation.x, Ball.transform.rotation.y, Ball.transform.rotation.z);
    }
}