using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZScriptCylinder : MonoBehaviour
{
    public bool IsTranslate;
    public bool IsRotate;
    public bool IsScale;

    void Update()
    {
        if (IsTranslate)
        {
            transform.position = transform.position + new Vector3(0, 0, 0) * Time.deltaTime;
        }
        if (IsRotate)
        {
            transform.eulerAngles = transform.eulerAngles + new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        if (IsScale)
        {
            transform.localScale = transform.localScale + new Vector3(0, 0, 0) * Time.deltaTime;
        }
    }
}