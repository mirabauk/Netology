using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRot : MonoBehaviour
{ 
    [SerializeField] public float speed = 1; 

        void Update()
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime * speed);
        }
    }