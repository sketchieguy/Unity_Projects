using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{

    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdownRun;
    public GameObject fadeIn;

    public AudioSource readyFX;
    public AudioSource goFX;
   
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdownRun.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;
    }
    
}
