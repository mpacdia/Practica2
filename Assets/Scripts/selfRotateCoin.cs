using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfRotateCoin : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 85 * Time.deltaTime, Space.Self);

    }
}
