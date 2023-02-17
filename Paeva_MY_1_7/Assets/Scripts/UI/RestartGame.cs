using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System;
using System.Reflection;


public class RestartGame : MonoBehaviour
{
    public static float tim;

    void Start()
    {
        tim = TimeScript.Seconds;
    }

    void Update()
    {

    }

    public void LoadGame()
    {
        SceneManager.LoadScene("GameRunner");
        ClearLog();
        ScoreValue.ScoreVal = 0;
        LifesValue.LifesVal = 3;
        TimeScript.Seconds = 0;
    }

    public void ClearLog()
    {
        var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        var type = assembly.GetType("UnityEditor.LogEntries");
        var method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
}
