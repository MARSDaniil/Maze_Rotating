using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnOnOffGameMenu : MonoBehaviour
{
    public GameObject offCanvas;
    public GameObject onCanvas;

    public string nameOfDisableObject;
    public string nameOfAbleObject;
    private void Start()
    {
        
        if (nameOfDisableObject != null)
        {
            offCanvas = GameObject.Find(nameOfDisableObject);
        }
        if (nameOfAbleObject != null)
        {
            onCanvas = GetComponent<GameObject>();
        }
    }

    private void TurnOnCanvas()
    {
        onCanvas.SetActive(true);
        
    }

    public void TurnOffCanvas()
    {
        offCanvas.SetActive(false);
        TurnOnCanvas();
    }
}
