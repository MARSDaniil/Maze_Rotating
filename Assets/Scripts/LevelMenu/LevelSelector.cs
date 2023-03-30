using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelector : MonoBehaviour
{

    public Button[] levelBottonArray;
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < levelBottonArray.Length; i++)
        {
            if(i+2>levelAt)
            {
                levelBottonArray[i].interactable = false;
            }
        }
    }


}
