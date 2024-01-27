using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject checkObject1;
    public GameObject checkObject2;

    public GameObject putObject1;
    public GameObject putObject2;

    public Transform location;

    private bool isHoldingObject = false;
    // Update is called once per frame
    void Update()
    {
        if (putObject1.activeInHierarchy || putObject2.activeInHierarchy)
        {
            isHoldingObject = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isHoldingObject)
            {
                DropObject();
            }
        }
    }

    void DropObject()
    {
        if (putObject1.activeInHierarchy)
        {
            checkObject1.transform.position = location.position;
            checkObject1.SetActive(true);
            putObject1.SetActive(false);
            
        }
        else if (putObject2.activeInHierarchy)
        {
            checkObject2.transform.position = location.position;
            checkObject2.SetActive(true);
            putObject2.SetActive(false);
            
        }

        isHoldingObject = false;
    }
}
