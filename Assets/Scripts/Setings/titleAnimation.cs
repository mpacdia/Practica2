using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleAnimation : MonoBehaviour
{
    public GameObject animatedObject;
    private LeanTweenType easingType = LeanTweenType.easeOutQuad;


    private void Color()
    {
        LeanTween.color(animatedObject, Color.red, 0.5f).setEase(easingeaseInOutBack);
    }
}
