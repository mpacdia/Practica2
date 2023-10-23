using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPoint : MonoBehaviour
{
    public GameObject character;

    // Update is called once per frame
    void Update()
    {
        transform.position = character.transform.position;
    }
}
