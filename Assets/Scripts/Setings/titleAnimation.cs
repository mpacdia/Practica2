using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class titleAnimation : MonoBehaviour
{
    private void appearAnimation()
    {
        LeanTween.scale(this.gameObject, new Vector3(6f, 6f, 6f), 1.5f).setEaseInOutSine();
    }

    void Start()
    {
        LeanTween.init(10000);
        appearAnimation();
    }
}
