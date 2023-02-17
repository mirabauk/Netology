using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private float CountNum;
    private float a;
    private static float b;
    private float c;
    private float d;
    Text countNum;

    // Start is called before the first frame update
    void Start()
    {
        countNum = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        a = (ScoreValue.Points)*1;
        b = (RestartGame.tim)*1;
        c = (a / b)*10;
        d = (float)Math.Round(c);
        countNum.text = "Count: " + d;
    }
}
