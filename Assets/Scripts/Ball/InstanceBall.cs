using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBall : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    // Start is called before the first frame update
    public GameObject Board;

    void Start()
    {
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();

        Ball.transform.position = new Vector3(-(mazeSpawner.sizeOfMaze) / 2, -(mazeSpawner.sizeOfMaze) / 2, -0.5f);

    }
}
