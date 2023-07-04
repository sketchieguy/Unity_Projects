using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectController.coinCounter++;
        this.gameObject.SetActive(false);
        
    }
}
