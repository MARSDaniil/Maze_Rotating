using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine.Networking;
using UnityEngine;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Hello();


    [DllImport("_Internal")]
    private static extern void RateGame();

    public void HelloBotton()
    {
        Hello();
    }

    public void RateGameBotton()
    {
        RateGame();
    }
}
