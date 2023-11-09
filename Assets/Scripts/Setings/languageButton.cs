using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class languageButton : MonoBehaviour
{
    public AudioSource musicEnglish;
    public AudioSource musicSpanish;
    public AudioSource musicItalian;
    public AudioSource musicCanarian;

    private int currentLanguage = 3;
    public void setEnglish()
    {
        musicEnglish.Play();
        musicSpanish.Stop();
        musicCanarian.Stop();
        musicItalian.Stop();
        difficultyButton.languageNumber = 0;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[1]);
    }
    public void setSpanish()
    {
        musicEnglish.Stop();
        musicSpanish.Play();
        musicCanarian.Stop();
        musicItalian.Stop();
        difficultyButton.languageNumber = 1;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[3]);
    }
    public void setItalian()
    {
        musicEnglish.Stop();
        musicSpanish.Stop();
        musicCanarian.Stop();
        musicItalian.Play();
        difficultyButton.languageNumber = 2;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[2]);
    }
    public void setCanarian()
    {
        musicEnglish.Stop();
        musicSpanish.Stop();
        musicCanarian.Play();
        musicItalian.Stop();
        difficultyButton.languageNumber = 3;
        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
    }

    public void forwardButton()
    {
        if (currentLanguage == 3)
        {
            currentLanguage = 0;
            LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);

        }
        else
        {
            currentLanguage++;
            LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[currentLanguage]);
        }
    }
    public void backwardButton()
    {
        if (currentLanguage == 0)
        {
            currentLanguage = 3;
            LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[3]);
        }
        else
        {
            currentLanguage--;
            LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[currentLanguage]);
        }
    }


}
