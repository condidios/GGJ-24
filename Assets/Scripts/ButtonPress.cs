using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    public Sprite pressed;

    public Sprite notPressed;
    private bool isPressed = false;
    private SpriteRenderer spriteRenderer;
    public GameObject door;
    public ButtonPress otherButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = notPressed;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed || otherButton.isPressed)
        {
            spriteRenderer.sprite = pressed;
            door.gameObject.SetActive(false);
        }
        else
        {
            spriteRenderer.sprite = notPressed;
            door.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            isPressed = true;
            other.transform.position = gameObject.transform.position + new Vector3(0, 0.4f, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            isPressed = false;
        }
    }
}
