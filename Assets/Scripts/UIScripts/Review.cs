using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
public class Review : MonoBehaviour
{
    public void OpenReview()
    {
        if (YandexGame.SDKEnabled == true)
        {
            YandexGame.ReviewShow(true);
        } 
    }
}
