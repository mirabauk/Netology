using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHit : Obstacle
{
    Rigidbody fire;
    // Start is called before the first frame update
    void Start()
    {
        fire = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
