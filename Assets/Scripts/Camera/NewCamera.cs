using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCamera : MonoBehaviour
{

    [SerializeField] Camera Camera;

    public GameObject Board;
    public GameObject Ball;
    MazeSpawner mazeSpawner;
    public float rangeFactor = 1;
    [SerializeField]
    private float boardOfInsideSquare;
    [SerializeField]
    private float diamondAngle;


    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float upperLimit;

    // Update is called once per frame
    void Start()
    {
        Board = GameObject.Find("Maze Spawner");
        mazeSpawner = Board.GetComponent<MazeSpawner>();

        boardOfInsideSquare = ((mazeSpawner.sizeOfMaze - 1)/2);
        diamondAngle = (Mathf.Sqrt(Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2) + Mathf.Pow((mazeSpawner.sizeOfMaze - 1) / 2, 2)))+1;
        Camera.orthographicSize = boardOfInsideSquare; 
 
    }


    private void Update()
    {
        // follow ball

        /*
        Camera.transform.position = new Vector3(
            Ball.transform.position.x,
            Ball.transform.position.y,
            transform.position.z
            ) ;
        */


        /*
            Camera.transform.position = new Vector3(

            Mathf.Clamp(transform.position.x, -boardOfInsideSquare, boardOfInsideSquare),
            Mathf.Clamp(transform.position.y, -boardOfInsideSquare, boardOfInsideSquare),
            transform.position.z
            ) ;
        */
        /*
        if(Mathf.Abs(Ball.transform.position.y) > boardOfInsideSquare)
        {
            Camera.transform.position = new Vector3(
           transform.position.x,
           Ball.transform.position.y,
           transform.position.z
           );

            Debug.Log("U exite to board");
            Camera.transform.position = new Vector3(
                transform.position.x,
                Mathf.Clamp(transform.position.y, -diamondAngle, diamondAngle),
                transform.position.z
                );
        }
        */

        /*

        Camera.transform.position = new Vector3(
          transform.position.x,
          Ball.transform.position.y,
          transform.position.z
          );

        Debug.Log("U exite to board");
        Camera.transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -(diamondAngle- boardOfInsideSquare), (diamondAngle - boardOfInsideSquare)),
            transform.position.z
            );
        */


        if (Ball.transform.position.y < -boardOfInsideSquare+1)
        {
           
            Camera.transform.position = new Vector3(
                transform.position.x,
                 Mathf.Clamp(Ball.transform.position.y + boardOfInsideSquare-1, -(diamondAngle + boardOfInsideSquare), (diamondAngle - boardOfInsideSquare)),
                transform.position.z
                ) ;
            
        }
        else if(Ball.transform.position.y > boardOfInsideSquare-1)
        {
           
            Camera.transform.position = new Vector3(
               transform.position.x,
                Mathf.Clamp(Ball.transform.position.y - boardOfInsideSquare + 1, -(diamondAngle + boardOfInsideSquare), (diamondAngle - boardOfInsideSquare)),
               transform.position.z
               );
        }
        else if(Mathf.Abs(Ball.transform.position.y) < boardOfInsideSquare)
        {
            Camera.transform.position = new Vector3(
                0, 0, transform.position.z
                ) ;
         }
        

    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(-boardOfInsideSquare , boardOfInsideSquare), new Vector2(boardOfInsideSquare, boardOfInsideSquare));
        Gizmos.DrawLine(new Vector2(-boardOfInsideSquare , -boardOfInsideSquare ), new Vector2(boardOfInsideSquare , -boardOfInsideSquare ));
        Gizmos.DrawLine(new Vector2(-boardOfInsideSquare, boardOfInsideSquare), new Vector2(-boardOfInsideSquare , -boardOfInsideSquare));
        Gizmos.DrawLine(new Vector2(boardOfInsideSquare, boardOfInsideSquare ), new Vector2(boardOfInsideSquare , -boardOfInsideSquare));

    }

}
