using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunScreen : MonoBehaviour
{
    public GameObject endScreen;
    void Start()
    {
        StartCoroutine(EndSequence());
    }
    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        endScreen.SetActive(true);
    }
    
}
