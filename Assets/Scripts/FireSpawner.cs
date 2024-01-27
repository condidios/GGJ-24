using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    
    public GameObject fire;
    public Transform transform0;
    public Transform transform1;
    public Transform transform2;
    public Transform transform3;
    public Transform transform4;
    public float startSec;
    public float repeatRate;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createFire",startSec,repeatRate);
    }

    void createFire()
    {
        GameObject instance = Instantiate(fire);
        GameObject instance2 = Instantiate(fire);
        GameObject instance3 = Instantiate(fire);
        GameObject instance4= Instantiate(fire);
        GameObject instance5 = Instantiate(fire);

        instance.transform.position = transform0.position;
        instance2.transform.position = transform1.position;
        instance3.transform.position = transform2.position;
        instance4.transform.position = transform3.position;
        instance5.transform.position = transform4.position;
        
        Destroy(instance,2.9f);
        Destroy(instance2,2.9f);
        Destroy(instance3,2.9f);
        Destroy(instance4,2.9f);
        Destroy(instance5,2.9f);
    }
}