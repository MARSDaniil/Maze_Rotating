using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherAudioBotton : MonoBehaviour
{
   public GameObject AudioOff;
   public GameObject AudioOn;
    // Start is called before the first frame update
    void Start()
    {
        switch (AudioListener.volume)
        {
            case 0:
                AudioOff.SetActive(true);
                return;
            case 1:
                AudioOn.SetActive(true);
                return;
        }

    }

    // Update is called once per frame
 
}
