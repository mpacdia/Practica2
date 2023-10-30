using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class difficultyButton : MonoBehaviour
{
    public TMP_Text boton;
    public void button()
    {
        if(boton.text == "Easy")
        {
            boton.text = "Normal";
        }
        else if (boton.text == "Normal")
        {
            boton.text = "Hard";
        }
        else if (boton.text == "Hard")
        {
            boton.text = "Easy";
        }

    }
}
