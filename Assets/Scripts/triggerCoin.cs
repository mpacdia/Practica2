using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCoin : MonoBehaviour
{
    public AudioSource coinSoundEffect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "character")
        {
            characterController.addCoin();
            coinSoundEffect.Play();
            Destroy(gameObject);
        }
    }
}
