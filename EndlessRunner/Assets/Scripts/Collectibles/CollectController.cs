using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectController : MonoBehaviour
{
    public int coinCounter;
    public Text scoreText;

    public void IncrementScore()
    {
        coinCounter++;
        scoreText.text = "" + coinCounter;
    }

    /*public GameObject coinDisplay;
    void Update()
    {
        coinDisplay.GetComponent<Text>().text = "" + coinCount;
    }*/

    public static CollectController inst;

    private void Awake()
    {
        inst = this;
    }
}
