using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class difficultyButton : MonoBehaviour
{
    public TMP_Text boton;

    public static int languageNumber = 1;

    public List<string> difficultyListEnglish = new List<string>();
    public List<string> difficultyListSpanish = new List<string>();
    public List<string> difficultyListItalian = new List<string>();
    public List<string> difficultyListCanarian = new List<string>();
    public List<List<string>> difficultyList = new List<List<string>>();

    private void Start()
    {
        difficultyListEnglish.Add("Easy"); difficultyListEnglish.Add("Normal"); difficultyListEnglish.Add("Hard");
        difficultyListSpanish.Add("Facil"); difficultyListSpanish.Add("Normal"); difficultyListSpanish.Add("Dificil");
        difficultyListItalian.Add("Facile"); difficultyListItalian.Add("Normale"); difficultyListItalian.Add("Difficile");
        difficultyListCanarian.Add("Tenerife"); difficultyListCanarian.Add("Lanzarote"); difficultyListCanarian.Add("El Hierro");

        difficultyList.Add(difficultyListEnglish); difficultyList.Add(difficultyListSpanish); difficultyList.Add(difficultyListItalian); difficultyList.Add(difficultyListCanarian);

    }

    private void Update()
    {
        if (boton.text != difficultyList[languageNumber][0])
        {
            if (boton.text == difficultyList[languageNumber][1] || boton.text == difficultyList[languageNumber][2])
            {

            }
            else
            {
                for (int i = 0; i < difficultyList.Count; i++)
                {
                    for (int j = 0; j < difficultyListSpanish.Count; j++)
                    {
                        if (boton.text == difficultyList[i][j])
                        {
                            boton.text = difficultyList[languageNumber][j];
                        } 
                    }
                }
            }
        }
    }


    public void button()
    {
       
        if (boton.text == difficultyList[languageNumber][0])
        {
            boton.text = difficultyList[languageNumber][1];
        }
        else if (boton.text == difficultyList[languageNumber][1])
        {
            boton.text = difficultyList[languageNumber][2];
        }
        else if (boton.text == difficultyList[languageNumber][2])
        {
            boton.text = difficultyList[languageNumber][0];
        }
    }
}
