using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 6;
    public float horizontalSpeed = 4;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    public static bool isAlive = true;

    void Update()
    {
        if (CollectBoost.isBoost == true)
        {
           // transform.Translate(Vector3.forward * moveSpeed * 2 * Time.deltaTime, Space.World);
            //CollectBoost.isBoost = false;
            StartCoroutine(BoostSequence());
            
        }
        else
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        }
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime * -1);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if(isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }
        if(isJumping == true)
        {
            if(comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime *3, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -4, Space.World);
            }
        }
    }
    IEnumerator JumpSequence()
    {
        float initialHeight = transform.position.y;
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);
        if (isAlive == true)
        {
            playerObject.GetComponent<Animator>().Play("Run");
        }
    }
    IEnumerator BoostSequence()
    {
        transform.Translate(Vector3.forward * moveSpeed * 2 * Time.deltaTime, Space.World);
        yield return new WaitForSeconds(3);
        CollectBoost.isBoost = false;
    }
}
