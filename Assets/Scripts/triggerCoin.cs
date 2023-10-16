using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "character")
        {
            characterController.addCoin();
            Destroy(gameObject);
        }
    }
}
