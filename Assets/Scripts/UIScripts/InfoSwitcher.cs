using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSwitcher : Switcher
{
    public float timeOfWait;

    public GameObject MobileText;
    public GameObject PcText;

    private void Awake()
    {

#if UNITY_STANDALONE || UNITY_WEBGL

        if(Application.isMobilePlatform == true)
        {
            MobileText.SetActive(true);
        }
        else
        {
            PcText.SetActive(true);
        }
#endif
#if UNITY_IOS || UNITY_ANDROID
         MobileText.SetActive(true);
#endif
    }

    private void Start()
    {
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
       
        yield return new WaitForSeconds(timeOfWait);
        TurnOff();
    }
}

