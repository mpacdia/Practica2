using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicToggle : MonoBehaviour
{
    public bool newState = true;

   public void toggle(bool newState)
    {
        if (newState)
        {
            Debug.Log("M�sic On");
        }
        else
        {
            Debug.Log("Music Off");
        }
    }
}
