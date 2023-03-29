using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class SwitchBottonToLocalization : MonoBehaviour
{
    public GameObject EnBotton;
    public GameObject RuBotton;
    public GameObject EsBotton;
    public GameObject FrBotton;

    void Start()
    {
        int startNumOfLocale = LocalizationSettings.SelectedLocale.SortOrder;

switch(startNumOfLocale)
        {
            case 0:
                EnBotton.SetActive(true);
                break;
            case 1:
                RuBotton.SetActive(true);
                break;
            case 2:
                EsBotton.SetActive(true);
                break;
            case 3:
                FrBotton.SetActive(true);
                break;
        }


    }

    IEnumerator WaitTime()
    {

        yield return new WaitForSeconds(4);
    }

}
