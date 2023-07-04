using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBoost : MonoBehaviour
{
    public AudioSource boostFX;
    public static bool isBoost = false;
    void OnTriggerEnter(Collider other)
    {
        boostFX.Play();
        isBoost = true;
        this.gameObject.SetActive(false);

    }
}
