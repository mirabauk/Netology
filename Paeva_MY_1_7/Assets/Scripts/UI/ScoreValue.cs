using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValue : MonoBehaviour
{
    public static float Dyst;
    public static float Points;
    public static float ScoreVal = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        Points = ((float)Math.Round(Dyst*1))*10 + ScoreVal;
        score.text = "Score: " + Points;
    }
}