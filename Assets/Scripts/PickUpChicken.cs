using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpChicken : MonoBehaviour
{
    public GameObject ChickenOnPlayer;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        ChickenOnPlayer.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                text.SetActive(false);
                gameObject.SetActive(false);
                ChickenOnPlayer.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}
    
