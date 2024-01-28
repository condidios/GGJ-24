using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public GameObject text;
    private bool isTalk = false;
    
    
    void Update()
    {
        if (isTalk)
        {
            text.gameObject.SetActive(true);
        }
        else
        {
            text.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTalk = true;
        }
        else
        {
            isTalk = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTalk = false;
        }
        else
        {
            isTalk = false;
        }
    }
}
