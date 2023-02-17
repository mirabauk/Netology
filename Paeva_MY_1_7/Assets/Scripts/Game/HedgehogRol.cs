using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HedgehogRol : Obstacle
{
    [SerializeField] public float SpeedRoll = 15;
    public float SpeedRun = 15;
    public float SpeedMove = 4f;
    public float time = 2f;

    private void Start()
    {
        GameVelocity();
    }

    private void GameVelocity()
    {
        var rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(SpeedRun, 0f, 0f);
        SpeedRun = -SpeedRun;
    }

    private void GameRotation()
    {
        SpeedRoll = -SpeedRoll;
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Lava")
        {
Destroy(this.gameObject);
            //Debug.Log("Hedgehog is destroyed");
        }
    }

        private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * SpeedRoll);
        time -= Time.deltaTime;
        if (time < 0)
        {
            GameVelocity();
            GameRotation();
            time = 2f;
        }
    }
}
