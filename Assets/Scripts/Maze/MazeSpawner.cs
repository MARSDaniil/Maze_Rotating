using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MazeSpawner : MonoBehaviour
{

    public GameObject CellPrefab;
    public int sizeOfMaze;



    private void Start()
    { 

        MazeGenerator generator = new MazeGenerator();
        generator.SetParam(sizeOfMaze);
        MazeGeneratorCell[,] maze = generator.GenerateMaze();

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                Cell c = Instantiate(CellPrefab, new Vector3(x- maze.GetLength(0)/2, y- maze.GetLength(1)/2, -0.5f), Quaternion.identity).GetComponent<Cell>();
                c.transform.parent = gameObject.transform;
                c.wallLeft.SetActive(maze[x, y].wallLeft);
                c.wallBottom.SetActive(maze[x, y].wallBottom);
            }
        }
    }
    
}

