using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject Board;
    public Color[] color; 
    void Start()
    {
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();

        gameObject.transform.localScale = new Vector3(mazeSpawner.sizeOfMaze-1, mazeSpawner.sizeOfMaze-1, 0.01f);
        gameObject.GetComponent<Renderer>().material.color = color[2];
    }
}
