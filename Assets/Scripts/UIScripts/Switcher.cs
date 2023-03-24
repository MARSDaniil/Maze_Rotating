using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Switcher : MonoBehaviour
{
    public  GameObject buttonOn;


    private void Start()
    {
        if (buttonOn == null)
        {
            buttonOn = GetComponent<GameObject>();
        }
    }
    public void TurnOff()
    { 
        gameObject.SetActive(false);
        TurnOn();
    }

    private void TurnOn()
    {
        buttonOn.gameObject.SetActive(true);
    }

}
