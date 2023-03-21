using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject Board;
    public Color[] color;

    public int CoeffOfScale = 1;
    void Start()
    {
        Board = GameObject.Find("Maze Spawner");
        MazeSpawner mazeSpawner = Board.GetComponent<MazeSpawner>();

        Scale(mazeSpawner);
        if (color.Length > 0)
        {
            Colour();
        }
    }

    private void Scale(MazeSpawner mazeSpawner)
    {
        gameObject.transform.localScale = new Vector3((mazeSpawner.sizeOfMaze - 1)* CoeffOfScale, (mazeSpawner.sizeOfMaze - 1) * CoeffOfScale, 0.01f);
    }

    private void Colour()
    {
        gameObject.GetComponent<Renderer>().material.color = color[Random.Range(0, color.Length)];
    }
}
