using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeFin : MonoBehaviour
{
    Text timefin;
    void Start()
    {
        timefin = GetComponent<Text>();
    }

    void Update()
    {
        timefin.text = "Time: " + RestartGame.tim;
    }
}
