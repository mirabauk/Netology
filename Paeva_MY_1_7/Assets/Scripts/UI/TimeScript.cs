using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{

    public static float Seconds;

    Text time;
    void Start()
    {
        time = GetComponent<Text>();
    }

    void Update()
    {
        Seconds = (float)Math.Round(Time.time);
        time.text = "Time: " + Seconds;
    }
}
