using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonText : MonoBehaviour
{
    public GameObject text;
    

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                text.transform.position = new Vector3(2000, 2000, 2000);
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