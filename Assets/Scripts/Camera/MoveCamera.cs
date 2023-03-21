using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    [SerializeField] Camera Camera;

    public GameObject Board;

    public float rangeFactor = 1;

    // Update is called once per frame
    void Start()
    {
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();

        Camera.transform.position = new Vector3(0, 0, -mazeSpawner.sizeOfMaze* rangeFactor);
    }
}
