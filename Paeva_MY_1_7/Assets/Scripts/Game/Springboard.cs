using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springboard : Obstacle
{
    Rigidbody SB;
    // Start is called before the first frame update
    void Start()
    {
        SB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
