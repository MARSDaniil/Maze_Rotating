using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class MazeGeneratorCell
{
    public int X;
    public int Y;

    public bool wallLeft = true;
    public bool wallBottom = true;
    public bool Visited = false;
}

public class MazeGenerator
{
    public int Xcoord;
    public int Ycoord;
    [SerializeField] public GameObject CellPrefab;

    public int width = 10;
    public int height = 10;

  
   
    public MazeGeneratorCell[,] GenerateMaze()
    {
        MazeGeneratorCell[,] maze = new MazeGeneratorCell[width, height];


        DeleteOuterWall(maze);//удаление внешних стен(право и верх, край)

        RomoveWallWithBackTracker(maze);//создание лабиринта путем удаления внутренних стен

      Exit(maze); //удаление стены, тем самым генерируя выход
       

        return maze;
    }

    public void DeleteOuterWall(MazeGeneratorCell[,] maze)
    {
        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                maze[x, y] = new MazeGeneratorCell { X = x, Y = y };
            }
        }

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            maze[x, height - 1].wallLeft = false;
        }

        for (int y = 0; y < maze.GetLength(1); y++)
        {
            maze[width - 1, y].wallBottom = false;
        }
    }

    private void Exit(MazeGeneratorCell[,] maze)//генерация выхода
    {

        System.Random rnd = new System.Random();
        float num = rnd.Next(0, 2);
        int randomLeftOrBottom = (int)Math.Round(num, 0);
      
        


        if (randomLeftOrBottom == 0)
        {
            float numRand = rnd.Next(0, height - 1);
            int numRandInt = (int)Math.Round(numRand, 0);

            maze[width - 1, numRandInt].wallLeft = false;
        }
        else
        {
            float numRand = rnd.Next(0, width - 1);
            int numRandInt = (int)Math.Round(numRand, 0);

            maze[numRandInt, height-1].wallBottom = false;
        }
      
    }

    private void RomoveWallWithBackTracker(MazeGeneratorCell[,] maze)//убирание лишних стен через стэк
    {
        MazeGeneratorCell current = maze[0, 0];
        current.Visited = true;
        Stack<MazeGeneratorCell> stack = new Stack<MazeGeneratorCell>();
        do
        {
            List<MazeGeneratorCell> unvisitedNeiborhood = new List<MazeGeneratorCell>();

            int x = current.X;
            int y = current.Y;
            if (x>0 && !maze[x-1, y].Visited)
            {
                unvisitedNeiborhood.Add(maze[x-1, y]);
            }
            if (y > 0 && !maze[x, y-1].Visited)
            {
                unvisitedNeiborhood.Add(maze[x , y-1]);
            }

            if (x < height - 2 && !maze[x+1, y ].Visited)
            {
                unvisitedNeiborhood.Add(maze[x+1, y]);
            }

            if (y < height -2  && !maze[x, y + 1].Visited)
            {
                unvisitedNeiborhood.Add(maze[x, y + 1]);
            }
            if(unvisitedNeiborhood.Count>0)
            {
                MazeGeneratorCell choosen = unvisitedNeiborhood[UnityEngine.Random.Range(0, unvisitedNeiborhood.Count)];
                RemoveWall(current, choosen);
                choosen.Visited = true;
                stack.Push(choosen);
                current = choosen;

            }
            else
            {
                current = stack.Pop();
            }
        }
        while (stack.Count > 0);
    }

    private void RemoveWall(MazeGeneratorCell current, MazeGeneratorCell choosen)
    {
       if(current.X == choosen.X)
        {
            if(current.Y>choosen.Y)
            {
                current.wallBottom = false;
               
            }
            else
            {
                choosen.wallBottom = false;
            }
        }
       else
        {
            if (current.X > choosen.X)
            {
                current.wallLeft = false;

            }
            else
            {
                choosen.wallLeft = false;
            }
        }
    }
}
