using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
public class AudioSwitcher : MonoBehaviour
{
   public void OnSounds()
    {
        AudioListener.volume = 1f;
        YandexGame.savesData.isMusicOn = true;
        
    }

    public void OffSounds()
    {
        AudioListener.volume = 0f;
        YandexGame.savesData.isMusicOn = false;
    }
}
