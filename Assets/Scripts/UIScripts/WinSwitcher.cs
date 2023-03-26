using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSwitcher : Switcher
{
    public GameObject ball;
    private GameOver gameOver;

    void Start()
    {

        gameOver = ball.GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver.isWin == true)
        {
            TurnOff();
            TurnOn();
        }
    }
}
