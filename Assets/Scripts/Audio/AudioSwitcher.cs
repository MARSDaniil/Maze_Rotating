using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwitcher : MonoBehaviour
{
   public void OnSounds()
    {
        AudioListener.volume = 1f;
    }

    public void OffSounds()
    {
        AudioListener.volume = 0f;
    }
}
