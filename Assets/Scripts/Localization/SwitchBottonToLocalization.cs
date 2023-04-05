using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using YG;
public class SwitchBottonToLocalization : MonoBehaviour
{
    public GameObject EnBotton;
    public GameObject RuBotton;
    public GameObject EsBotton;
    public GameObject FrBotton;

    void Awake()
    {
        YandexGame.savesData.selectedLanguage = LocalizationSettings.SelectedLocale.SortOrder;
        if(LocalizationSettings.SelectedLocale == null)
        {
            YandexGame.savesData.selectedLanguage = 0;
            YandexGame.SaveProgress();
        }

        //   Debug.Log("LocalizationSettings.SelectedLocale" + LocalizationSettings.SelectedLocale);
        switch (YandexGame.savesData.selectedLanguage)
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


}
