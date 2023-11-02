using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleAnimation : MonoBehaviour
{
    public GameObject objectToAnimate;

    private void colorAnimation()
    {
        LeanTween.color(objectToAnimate, Color.red, 0.5f).setEaseOutCubic();
    }

    private void delayColor()
    {
        LeanTween.delayedCall(3.5f, () => {
            colorAnimation();
        }).setRepeat(100);
    }

    private void appearAnimation()
    {
        LeanTween.scale(objectToAnimate, new Vector3(6f, 6f, 6f), 1.5f).setEaseInOutSine();
    }

    void Start()
    {
        LeanTween.init(10000);
        appearAnimation();
        delayColor();
    }
}
