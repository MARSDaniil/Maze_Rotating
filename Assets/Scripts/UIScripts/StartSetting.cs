using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetting : MonoBehaviour
{
    public GameObject[] OpenCanvasMenu;
    public GameObject[] CloseCanvasMenu;

    private void Start()
    {
        SetAnotherValue(OpenCanvasMenu, true);
        SetAnotherValue(CloseCanvasMenu, false);
    }

    private void SetAnotherValue(GameObject[] Objects, bool value)
    {
        for (int i = 0; i < Objects.Length; i++)
        {
            Objects[i].SetActive(value);
        }
    }

}
