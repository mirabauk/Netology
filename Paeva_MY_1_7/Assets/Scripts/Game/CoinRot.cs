using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRot : MonoBehaviour
{
    [SerializeField]
    public float SpeedRoll = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void GameRotation()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 0, 0) * Time.deltaTime * SpeedRoll);
    }
}
