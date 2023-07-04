using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectController : MonoBehaviour
{
    public static int coinCounter;
    public GameObject coinDisplay;


    
    void Update()
    { 
        coinDisplay.GetComponent<Text>().text = "" + coinCounter;
    }

   
}
