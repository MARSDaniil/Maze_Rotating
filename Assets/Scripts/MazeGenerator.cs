using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    [SerializeField] public GameObject CellPrefab;

    public int width = 15;
    public int height = 15;

   
    public MazeGeneratorCell[,] GenerateMaze()
    {
        MazeGeneratorCell[,] maze = new MazeGeneratorCell[width, height];

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
            maze[width-1,y].wallBottom = false;
        }

        RomoveWallWithBackTracker(maze);

        return maze;
    }

    private void RomoveWallWithBackTracker(MazeGeneratorCell[,] maze)
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
                MazeGeneratorCell choosen = unvisitedNeiborhood[Random.Range(0, unvisitedNeiborhood.Count)];
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
