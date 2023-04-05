using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
public class SwitcherAudioBotton : MonoBehaviour
{
   public GameObject AudioOff;
   public GameObject AudioOn;
    // Start is called before the first frame update
    void Start()
    {
        //musicSwitcherWithout YaSDK

        /*
        switch (AudioListener.volume)
        {
            case 0:
                AudioOff.SetActive(true);
                return;
            case 1:
                AudioOn.SetActive(true);
                return;
        }
        */

        switch (YandexGame.savesData.isMusicOn)
        {
            case false:
                AudioOff.SetActive(true);
                AudioOn.SetActive(false);
                return;
            case true:
                AudioOff.SetActive(false);
                AudioOn.SetActive(true);
                return;
        }

    }

    // Update is called once per frame
 
}
