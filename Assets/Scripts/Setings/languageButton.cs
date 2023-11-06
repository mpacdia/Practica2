using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languageButton : MonoBehaviour
{
    public void setEnglish()
    {
        difficultyButton.languageNumber = 0;
    }
    public void setSpanish()
    {
        difficultyButton.languageNumber = 1;
    }
    public void setItalian()
    {
        difficultyButton.languageNumber = 2;
    }
    public void setCanarian()
    {
        difficultyButton.languageNumber = 3;
    }
}
