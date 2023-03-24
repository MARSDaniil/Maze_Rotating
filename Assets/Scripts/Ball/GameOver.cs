using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Board;
    private  MazeSpawner mazeSpawner;
    public Rigidbody rb;

    public bool isWin = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Board = GameObject.Find("Maze Spawner");
        mazeSpawner = Board.GetComponent<MazeSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isWin == false)
        {


            if (gameObject.transform.position.y < (-Mathf.Sqrt(Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2) + Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2)) - 5))
            {
                isWin = true;
                Debug.Log("U win");
                rb.isKinematic = true;
            }
        }
    }
}
