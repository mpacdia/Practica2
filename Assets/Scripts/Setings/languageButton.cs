using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class languageButton : MonoBehaviour
{
    public void setEnglish()
    {
        difficultyButton.languageNumber = 0;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[1]);
    }
    public void setSpanish()
    {
        difficultyButton.languageNumber = 1;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[3]);

    }
    public void setItalian()
    {
        difficultyButton.languageNumber = 2;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[2]);

    }
    public void setCanarian()
    {
        difficultyButton.languageNumber = 3;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);

    }
}
