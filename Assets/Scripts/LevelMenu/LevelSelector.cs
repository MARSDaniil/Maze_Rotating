using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;
public class LevelSelector : MonoBehaviour
{
    [SerializeField] Text textOfLevelAt;
    [SerializeField] Text textOfDataLevelAt;
    public Button[] levelBottonArray;
    // Start is called before the first frame update
    void Start()
    {
        //подключение классического SDK через видео яндекса
        /*
        int levelAt;
        if (PlayerPrefs.GetInt("levelAt", 2) >=  Progress.Instance.PlayerInfo.Level)
        {
            levelAt = PlayerPrefs.GetInt("levelAt", 2);
            Progress.Instance.PlayerInfo.Level = levelAt;
            Progress.Instance.Save();
        }
        else
        {
            levelAt = Progress.Instance.PlayerInfo.Level;
        }
        */

        int levelAt;

        /*
        if (YandexGame.SDKEnabled == true && YandexGame.savesData.maxLevelOpen > 0)
        {


            levelAt = YandexGame.savesData.maxLevelOpen;
        }
        else
        {
            levelAt = PlayerPrefs.GetInt("levelAt", 2);
            
        }
        */

        if (YandexGame.SDKEnabled == true)
        {
            if (YandexGame.savesData.maxLevelOpen > 0)
            {
                levelAt = YandexGame.savesData.maxLevelOpen;
            }
            else 
            {
                levelAt = PlayerPrefs.GetInt("levelAt", 2);
                YandexGame.savesData.maxLevelOpen = levelAt;
            }
        }
        else 
        {
            levelAt = PlayerPrefs.GetInt("levelAt", 2);
        }


        for (int i = 0; i < levelBottonArray.Length; i++)
        {
            if(i+2>levelAt)
            {
                levelBottonArray[i].interactable = false;
            }
        }
        
      
    }
    


}
