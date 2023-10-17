using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject character;
    public float offsetX, offsetZ;

    // Update is called once per frame
    void Update()
    {
        // first person pov
        //transform.position = character.transform.position;

        // third person pov
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y + 1, character.transform.position.z - 5);
    }
}
