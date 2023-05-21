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
        //YandexGame.savesData.selectedLanguage = LocalizationSettings.SelectedLocale.SortOrder;

        /*
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
        */



        /*

        if(YandexGame.EnvironmentData.language == "ru" ||
            YandexGame.EnvironmentData.language == "be" ||
            YandexGame.EnvironmentData.language == "kk" ||
            YandexGame.EnvironmentData.language == "kz" ||
            YandexGame.EnvironmentData.language == "uz"
            )
        {
            RuBotton.SetActive(true);
            LocalizationSettings.SelectedLocale.SortOrder = 1;
            YandexGame.savesData.selectedLanguage = 1;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
            isLanguageSelected = true;
        }
        if(YandexGame.EnvironmentData.language == "es")
        {
            EsBotton.SetActive(true);
            LocalizationSettings.SelectedLocale.SortOrder = 2;
            YandexGame.savesData.selectedLanguage = 2;
            isLanguageSelected = true;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[2];
        }
        if (YandexGame.EnvironmentData.language == "fr")
        {
            FrBotton.SetActive(true);
            YandexGame.savesData.selectedLanguage = 3;
            LocalizationSettings.SelectedLocale.SortOrder = 3;
            isLanguageSelected = true;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[3];
        }
        if (isLanguageSelected == false)
        {
            EnBotton.SetActive(true);
            YandexGame.savesData.selectedLanguage = 0;
            LocalizationSettings.SelectedLocale.SortOrder = 0;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        }

        YandexGame.SaveProgress();
        */


      

        Debug.Log("LocalizationSettings.SelectedLocale" + LocalizationSettings.SelectedLocale);
        Debug.Log("LocalizationSettings.SelectedLocale.SortOrder" + LocalizationSettings.SelectedLocale.SortOrder);
       // string lang = LocalizationSettings.SelectedLocale.ToString();
        switch (LocalizationSettings.SelectedLocale.ToString())
        {
            case "English (en)":
                EnBotton.SetActive(true);
                break;
            case "Russian (ru)":
                RuBotton.SetActive(true);
                break;
            case "Spanish (es)":
                EsBotton.SetActive(true);
                break;
            case "French (fr)":
                FrBotton.SetActive(true);
                break;
            case null:
                RuBotton.SetActive(true);
                break;
        }
    }

    /*
    private void Update()
    {
        Debug.Log(LocalizationSettings.SelectedLocale.ToString());
    }
    */
}
