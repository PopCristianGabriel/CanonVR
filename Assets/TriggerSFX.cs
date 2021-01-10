using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public  AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "soundMaker")
        {
            playSound.Play();
            Debug.Log("Entered");

        }

        playSound.Play();
    }
}
