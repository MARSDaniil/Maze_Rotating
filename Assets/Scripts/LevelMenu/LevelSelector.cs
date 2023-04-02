using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{

    public Button[] levelBottonArray;
    // Start is called before the first frame update
    void Start()
    {
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
        
        for (int i = 0; i < levelBottonArray.Length; i++)
        {
            if(i+2>levelAt)
            {
                levelBottonArray[i].interactable = false;
            }
        }

      
    }
    


}
