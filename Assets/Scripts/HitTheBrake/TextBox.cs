using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class ChatBox : MonoBehaviour
{
    public String msg = "";
    private TMP_InputField textInputField;

    private const String WOMAN = "WOMAN";
    private const String CHILD = "CHILD";
    private const String BRAKE = "BRAKE";
    void Start()
    {
        textInputField = GetComponent<TMP_InputField>();
        msg = textInputField.text;
    }
    void Update()
    {
        textInputField.text = textInputField.text.ToUpper();
        if (msg != textInputField.text)
        {
            checkWord();
        }
    }

    void checkWord()
    {
        msg = textInputField.text;

        if (msg == WOMAN)
        {
            print(msg);
            //HitWoman();
        }
        else if (msg == CHILD)
        {
            print(msg);
            //HitChild();
        }
        else if (msg == BRAKE)
        {
            print(msg);
            //HitBrake();
        }
    }
}