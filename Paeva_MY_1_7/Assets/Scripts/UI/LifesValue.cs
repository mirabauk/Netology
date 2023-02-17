using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifesValue : MonoBehaviour
{
    public static int LifesVal = 3;
    Text lifes;

    void Start()
    {
        lifes = GetComponent<Text>();
    }

    void Update()
    {
        lifes.text = "Lifes: " + LifesVal;
    }
}