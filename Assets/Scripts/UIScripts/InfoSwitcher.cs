using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSwitcher : Switcher
{
    public float timeOfWait;
   public void Start()
    {
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
       
        yield return new WaitForSeconds(timeOfWait);
        TurnOff();
    }
}

