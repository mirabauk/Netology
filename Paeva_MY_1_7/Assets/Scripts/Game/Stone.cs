using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stone : Obstacle
{
    Rigidbody stonerb;

    // Start is called before the first frame update
    void Start()
    {
        stonerb = GetComponent<Rigidbody>();
        transform.rotation = Random.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
