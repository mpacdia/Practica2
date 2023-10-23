using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject character;
    public float offsetX, offsetZ;
    public bool firstPerson;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && firstPerson == false)
        {
            firstPerson = true;
        }
        else if (Input.GetKeyDown(KeyCode.C) && firstPerson == true)
        {
            firstPerson = false;
        }

        if (firstPerson)
        {
            transform.position = character.transform.position;
        }
        else
        {
            transform.position = new Vector3(character.transform.position.x, character.transform.position.y + 1, character.transform.position.z - 5);
        }
    }
}
