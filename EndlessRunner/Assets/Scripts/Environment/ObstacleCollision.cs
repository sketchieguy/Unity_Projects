using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashFall;
    public GameObject mainCam;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        PlayerMove.isAlive = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashFall.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunScreen>().enabled = true;
    }
}
