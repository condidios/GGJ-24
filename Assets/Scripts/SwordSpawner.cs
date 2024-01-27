using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSpawner : MonoBehaviour
{
    
    public GameObject sword;
    public float startSec;
    public float repeatRate;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createSword",startSec,repeatRate);
    }

    void createSword()
    {
        GameObject instance = Instantiate(sword);
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -7, 0);
        instance.transform.position = gameObject.transform.position;
        Destroy(instance,2);
    }
}
