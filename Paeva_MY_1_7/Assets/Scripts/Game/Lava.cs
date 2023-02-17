using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public Transform BeginLava;
    public Transform EndLava;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDestroy()
    {
        //Debug.Log($"Destroying on Z{transform.position.z}");
    }
}
